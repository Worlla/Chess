using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    public class Piece
    {
        /// <summary>
        /// Queen features
        /// </summary>

        #region Private members

        private string name;
        public bool isMoveAllowed;

        private int XActualCoordinate;
        private int YActualCoordinate;

        #endregion

        /// <summary>
        /// Initialize the Queen piece
        /// </summary>

        #region Public members

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int xActualCoordinate
        {
            get
            {
                return XActualCoordinate;
            }

            set
            {
                XActualCoordinate = value;
            }
        }

        public int yActualCoordinate
        {
            get
            {
                return YActualCoordinate;
            }

            set
            {
                YActualCoordinate = value;
            }
        }

        public Piece() { }

        public Piece(string Name, int xActualCoordinate, int yActualCoordinate)
        {
            this.Name = Name;
            this.xActualCoordinate = xActualCoordinate;
            this.yActualCoordinate = yActualCoordinate;
        }
        
        #endregion
    }
}
