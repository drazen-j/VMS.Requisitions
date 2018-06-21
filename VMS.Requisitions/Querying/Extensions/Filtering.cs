namespace VMS.Requisitions.Querying.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using VMS.Requisitions.Querying.Entities;

    /// <summary>
    /// The filtering.
    /// </summary>
    public static class Filtering
    {
        /// <summary>
        /// The active requisition statuses.
        /// </summary>
        public static readonly int?[] ActiveRequisitionStatuses =
            {
                (int)RequisitionStatus.Open,
                (int)RequisitionStatus.InterviewsOccuring
            };

        /// <summary>
        /// The inactive requisition statuses.
        /// </summary>
        public static readonly int?[] InactiveRequisitionStatuses =
            {
                (int)RequisitionStatus.BuySideBudgetNotApproved,
                (int)RequisitionStatus.ClosedCancelled,
                (int)RequisitionStatus.Draft,
                (int)RequisitionStatus.Filled,
                (int)RequisitionStatus.NotApproved,
                (int)RequisitionStatus.OnHold,
                (int)RequisitionStatus.PedningBuySideApproval,
                (int)RequisitionStatus.PendingApproval
            };

        /// <summary>
        /// The pending approval requisition statuses.
        /// </summary>
        public static readonly int?[] PendingApprovalRequisitionStatuses =
            {
                (int)RequisitionStatus.PendingApproval,
                (int)RequisitionStatus.PedningBuySideApproval
            };

        /// <summary>
        /// The all active requisitions.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="organizationIds">
        /// The organization Ids.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public static IQueryable<Requisition> AllActiveRequisitions(
            this IQueryingContext context,
            List<int> organizationIds)
        {
            return
                context.AllRequisitions(organizationIds)
                    .Where(
                        r =>
                            organizationIds.Contains(r.OrganizationId)
                            && (ActiveRequisitionStatuses.Contains(r.RequisitionStatusId)
                                || (r.RequisitionStatusId == (int)RequisitionStatus.PendingApproval
                                    && context.OrganizationDetails.Any(
                                        o =>
                                            o.OrganizationId == r.OrganizationId
                                            && !o.IsApprovalRequiredBeforeRequisitionDistribution))));
        }

        /// <summary>
        /// The all draft requisitions.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="organizationIds">
        /// The organization ids.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public static IQueryable<Requisition> AllDraftRequisitions(
            this IQueryingContext context,
            List<int> organizationIds)
        {
            return context.AllRequisitions(organizationIds).Where(r => r.RequisitionStatusId == (int)RequisitionStatus.Draft);
        }

        /// <summary>
        /// The all inactive requisitions.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="organizationIds">
        /// The organization for which to get requisitions.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public static IQueryable<Requisition> AllInactiveRequisitions(
            this IQueryingContext context,
            List<int> organizationIds)
        {
            return
                context.AllRequisitions(organizationIds)
                    .Where(r => InactiveRequisitionStatuses.Contains(r.RequisitionStatusId));
        }

        /// <summary>
        /// The all requisitions.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="organizationIds">
        /// The organization ids.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// If organization id is not provided.
        /// </exception>
        public static IQueryable<Requisition> AllRequisitions(
            this IQueryingContext context,
            List<int> organizationIds)
        {
            if (organizationIds == null || organizationIds.Count == 0)
            {
                throw new ArgumentException("At least one organization id must be provided", nameof(organizationIds));
            }

            return context.Requisitions.Where(r => !r.IsSowRequisition && organizationIds.Contains(r.OrganizationId));
        }

        /// <summary>
        /// The all requisitions pending approval.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="organizationIds">
        /// The organization ids.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public static IQueryable<Requisition> AllRequisitionsPendingApproval(
            this IQueryingContext context,
            List<int> organizationIds)
        {
            return
                context.AllRequisitions(organizationIds)
                    .Where(r => PendingApprovalRequisitionStatuses.Contains(r.RequisitionStatusId));
        }

        /// <summary>
        /// The all requisitions pending user approval.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="userId">
        /// The user id.
        /// </param>
        /// <param name="organizationIds">
        /// The organization ids.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public static IQueryable<Requisition> AllRequisitionsPendingUserApproval(
            this IQueryingContext context,
            int userId,
            List<int> organizationIds)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User Id must be greater than zero", nameof(userId));
            }

            return
                context.AllRequisitionsPendingApproval(organizationIds)
                    .Where(
                        r =>
                            context.RequisitionNextApprovers.Any(
                                rna =>
                                    rna.RequisitionId == r.Id
                                    && (rna.ApproverUserId == userId || rna.AlternateApproverUserId == userId)));
        }

        /// <summary>
        /// The for contact user.
        /// </summary>
        /// <param name="requisitions">
        /// The requisitions.
        /// </param>
        /// <param name="userId">
        /// The user id.
        /// </param>
        /// <param name="contactRoleId">
        /// The contact role id.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public static IQueryable<Requisition> ForContactUser(
            this IQueryable<Requisition> requisitions,
            int userId,
            RequisitionContactRole? contactRoleId = null)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User Id must be greater than zero", nameof(userId));
            }

            if (contactRoleId == null)
            {
                return requisitions.Where(r => r.RequisitionContacts.Any(rc => rc.UserId == userId));
            }

            return
                requisitions.Where(
                    r => r.RequisitionContacts.Any(rc => rc.UserId == userId && rc.ContactRoleId == contactRoleId.Value));
        }
    }
}