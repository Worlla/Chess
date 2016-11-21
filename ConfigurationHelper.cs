using System.Configuration;

namespace ChessGame.Help
{
    /// <summary>
    /// Helper used to read app.settings values.
    /// </summary>
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Get chessboard X coordinate value.
        /// </summary>
        /// <returns>X coordinate value.</returns>
        public static int GetBoardXValue()
        {
            return int.Parse(ConfigurationManager.AppSettings["boardX"]);
        }

        /// <summary>
        /// Get chessboard Y coordinate value.
        /// </summary>
        /// <returns></returns>
        public static int GetBoardYValue()
        {
            return int.Parse(ConfigurationManager.AppSettings["boardY"]);
        }
    }
}
