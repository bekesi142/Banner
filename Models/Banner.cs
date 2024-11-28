using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11282024.Models
{
    public class Banner : ABanner, IBannerOperations
    {
        public Banner() : base() { }
        public Banner(int row, int col) : base(row, col) { }

        public void Clear()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex] = Color.Black;
                }
            }
        }

        public void DrawLine(int rowIndex, Color drawingColor)
        {
            for (int column = 0; column < ColumnNum; column++)
            {
                this[rowIndex, column] = drawingColor;
            }
        }

        public void RotateToLeft()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color temp = this[RowNum, ColumnNum-1];
                for (int columnIndex = 1; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex - 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColumnNum - 1] = temp;
            }
        }

        public void RotateToRight()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color temp = this[RowNum, ColumnNum - 1];
                for (int columnIndex = ColumnNum - 1; columnIndex > 0; columnIndex++)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex - 1];
                }
                this[rowIndex, 0] = temp;
            }
        }

        public void ShiftToLeft(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {

                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex + 1];
                }
                this[rowIndex, ColumnNum - 1] = fillColor;
            }
        }

        public void ShiftToRight(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                
                for (int columnIndex = ColumnNum - 1; columnIndex > 0; columnIndex--)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex - 1];
                }
                this[rowIndex, 0] = fillColor;
            }
        }
    }
}
