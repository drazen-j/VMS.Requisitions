# VMS.Requisitions

Response Example:
```json
{
  "result": [
    {
      "id": 563870,
      "istemplate": false,
      "title": "Qtle Crebyle Qy",
      "ext": null,
      "numberOfOpenings": 1,
      "numberOfFilled": 0,
      "startDate": "2018-06-11T00:00:00",
      "endDate": null,
      "requisitionClass": {
        "id": 225442,
        "reqClassDescription": "Test Analyst Sr",
        "hourlyLowRate": {
          "amount": 30,
          "currency": 1
        },
        "hourlyHighRate": {
          "amount": 30,
          "currency": 1
        },
        "salaryLow": null,
        "salaryHigh": null
      },
      "requisitionStatus": 4,
      "openUntil": null,
      "duration": null,
      "isForSalariedContractor": false,
      "clientInternalNumber": null,
      "requisitionPriority": 1,
      "maximumSubmittalsByVendor": null,
      "customFields": [
        {
          "applicationArea": 6,
          "sequenceNumber": 7,
          "label": "Do you have a candidate identified?",
          "text": "No, I do not have a preidentified candidate"
        },
        {
          "applicationArea": 6,
          "sequenceNumber": 8,
          "label": "Fingerprinting Billing Cost Center",
          "text": "3008000023"
        },
        {
          "applicationArea": 6,
          "sequenceNumber": 9,
          "label": "AFE#",
          "text": "AFE39715"
        },
        {
          "applicationArea": 6,
          "sequenceNumber": 10,
          "label": "Job Type",
          "text": "Supplemental Staff"
        },
        {
          "applicationArea": 6,
          "sequenceNumber": 11,
          "label": "Provide Job Type if 'Other' was selected above",
          "text": null
        }
      ],
      "engagementTypes": [
        1
      ],
      "shortDescription": "abc123",
      "description": "abc123",
      "characteristics": null,
      "alternateEmail": "abc@eamil.com",
      "contacts": [
        {
          "requisitionContactType": 1,
          "firstname": "Ejwpz",
          "middleInitial": null,
          "lastName": "Flacefh"
        },
        {
          "requisitionContactType": 2,
          "firstname": "Zpwp (Njzcpcp Zpwpcrllqz",
          "middleInitial": null,
          "lastName": "Hvjexer"
        },
        {
          "requisitionContactType": 3,
          "firstname": "Tqjrst",
          "middleInitial": null,
          "lastName": "Piwavh"
        }
      ],
      "location": {
        "id": 80794,
        "name": "Nqjjqyvey, Tjsjq"
      },
      "costCenters": [
        {
          "id": 229825,
          "name": "B2B APPL TEST SUPPORT"
        }
      ],
      "generalLedgers": [],
      "projects": [
        {
          "id": 974985,
          "name": "Bjm-Naaapfan Garn"
        }
      ],
      "department": "abc123",
      "estimatedExpensesPerOpening": null,
      "rateStructure": {
        "id": 1730,
        "code": "TOS",
        "name": "U.S. Bank TOS Rate Structure"
      },
      "billRangeFromRate": {
        "amount": 28,
        "currency": 1
      },
      "billRangeToRate": {
        "amount": 28,
        "currency": 1
      },
      "doNotAllowSubmissionAboveMaxBillRate": true,
      "maxPayRate": {
        "amount": 28,
        "currency": 1
      },
      "hoursPerDay": 8,
      "daysPerWeek": 5,
      "rateInfoText": null,
      "budget": {
        "budgetLines": [
          {
            "sequenceNumber": 1,
            "billingRule": null,
            "rate": {
              "amount": 27680.02,
              "currency": 1
            },
            "numberOfOpenings": 1,
            "workHoursPerWeek": 40,
            "duration": 24.7143
          }
        ],
        "totalExpenseAllowance": null,
        "totalLabor": {
          "amount": 27680.02,
          "currency": 1
        },
        "total": {
          "amount": 27680.02,
          "currency": 1
        }
      },
      "skills": [
        {
          "name": "Understand Testing of Data Warehouse Quality/ ETL /Reports/ Dashboards",
          "sequenceNumber": 1,
          "skillType": 1,
          "duration": {
            "value": 5,
            "durationType": 4
          },
          "expertiseRating": null
        },
        {
          "name": "Test Plans/ Test Cases / Test Execution / Defect Reporting",
          "sequenceNumber": 2,
          "skillType": 1,
          "duration": {
            "value": 5,
            "durationType": 4
          },
          "expertiseRating": null
        },
        {
          "name": "Working experience in Agile methodology",
          "sequenceNumber": 3,
          "skillType": 1,
          "duration": {
            "value": 3,
            "durationType": 4
          },
          "expertiseRating": null
        }
      ],
      "globalSkills": null,
      "questions": null,
      "complianceGroups": [
        {
          "name": "U.S. Bank TOS Offshore",
          "isGlobal": false,
          "complianceItems": [
            {
              "id": 7023,
              "name": "EFCC Sanctions Screening",
              "owner": "Client",
              "due": 3
            },
            {
              "id": 4719,
              "name": "OFS Background Check (BGC): Existing Employee of Vendor with BGC completed within last 36 months (Approved Vendor Pilot Only)",
              "owner": "Vendor",
              "due": 4
            },
            {
              "id": 4720,
              "name": "OFS Background Check (BGC): New Employee of Vendor or Previous Vendor BGC is Older than 36 months (Approved Vendor Pilot Only)",
              "owner": "Client",
              "due": 3
            }
          ]
        }
      ]
    }
  ]
}
```