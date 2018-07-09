using System;
using System.Text;

using VMS.Shared.Logging;

// ReSharper disable once CheckNamespace - extension method class
namespace Microsoft.Extensions.Logging
{
    /// <summary>
    /// The logger extension methods.
    /// </summary>
    public static class LoggerExtensions
    {
        /// <summary>
        /// Logs the ASCII art logo.
        /// </summary>
        /// <param name="logger">
        /// The logger.
        /// </param>
        public static void AddAsciiArtLogo(this ILogger logger)
        {
            System.Console.Title = "VMS Requisitons Service";

            // ASCII Art Generator ==> http://patorjk.com/software/taag/#p=display&f=Standard
            var logoBuilder = new StringBuilder();
            logoBuilder.Append($"{Environment.NewLine}");
            logoBuilder.Append($@" __     ____  __ ____      ____                  _     _ _   _                 {Environment.NewLine}");
            logoBuilder.Append($@" \ \   / /  \/  / ___|    |  _ \ ___  __ _ _   _(_)___(_) |_(_) ___  _ __  ___ {Environment.NewLine}");
            logoBuilder.Append($@"  \ \ / /| |\/| \___ \    | |_) / _ \/ _` | | | | / __| | __| |/ _ \| '_ \/ __|{Environment.NewLine}");
            logoBuilder.Append($@"   \ V / | |  | |___) |   |  _ <  __/ (_| | |_| | \__ \ | |_| | (_) | | | \__ \{Environment.NewLine}");
            logoBuilder.Append($@"    \_/  |_|  |_|____/    |_| \_\___|\__, |\__,_|_|___/_|\__|_|\___/|_| |_|___/{Environment.NewLine}");
            logoBuilder.Append($@"                                        |_|                                    {Environment.NewLine}");
            logoBuilder.Append($"{Environment.NewLine}");

            logger.LogInformation(LoggingEvents.SYSTEM_STARTUP, logoBuilder.ToString());
        }
    }
}
