using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace game3
{
    class Board
    {
        const int BOARD_SIZE = 4;
        public Cell[,] gameBoard;
        Random random = new Random();
        int cellAddValue=0;
        public Board()
        {
            gameBoard = new Cell[BOARD_SIZE, BOARD_SIZE];
            resetBoard();      
        }
        public void resetBoard()
        {
            cellAddValue = 0;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    gameBoard[i, j] = new Cell();
                }
            }
            addNewField();
            addNewField();        
        }
        public void addNewField()
        {
            int row, column, value;
            bool notValid = true;
            while (notValid)
            {
                row = random.Next(0, BOARD_SIZE);
                column = random.Next(0, BOARD_SIZE);
                if (gameBoard[row, column].getValue() == 0)
                {
                    value = random.Next(10) < 9 ? 2 : 4;
                    gameBoard[row, column].setValue(value);
                    notValid = false;
                }
            }
        }
        public int takeBiggestTile()
        {
            int max = gameBoard[0, 0].getValue();
            for(int i=0;i<BOARD_SIZE;i++)
            {
                for(int j=0;j<BOARD_SIZE;j++)
                {
                    if (gameBoard[i, j].getValue() > max)
                        max = gameBoard[i, j].getValue();
                }
            }
            return max;
        }
        public bool isGameOver()
        {
            return isGridFull() && !isMovePossible();
        }
        private bool isGridFull()
        {
            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = 0; columns < BOARD_SIZE; columns++)
                {
                    if (gameBoard[rows, columns].isZeroValue())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool isMovePossible()
        {
            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = 0; columns < (BOARD_SIZE - 1); columns++)
                {
                    int columnsPlus = columns + 1;
                    if (gameBoard[rows, columns].getValue() == gameBoard[rows, columnsPlus].getValue())
                    {
                        return true;
                    }
                }
            }
            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                for (int rows = 0; rows < (BOARD_SIZE - 1); rows++)
                {
                    int rowsPlus = rows + 1;
                    if (gameBoard[rows, columns].getValue() == gameBoard[rowsPlus, columns].getValue())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool moveCellsUp()
        {
            bool occupied = false;

            if (moveCellsUpLoop())
                occupied = true;

            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = 0; columns < (BOARD_SIZE - 1); columns++)
                {
                    int columnsPlus = columns + 1;
                    occupied = combineCells(rows, columnsPlus, rows, columns, occupied);
                }
            }
            if (moveCellsUpLoop())
                occupied = true;

            return occupied;
        }
        private bool moveCellsUpLoop()
        {
            bool occupied = false;
            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                bool columnOccupied = false;
                do
                {
                    columnOccupied = false;
                    for (int columns = 0; columns < (BOARD_SIZE - 1); columns++)
                    {
                        int columnsPlus = columns + 1;
                        bool cellOccupied = moveCell(rows, columnsPlus, rows, columns);
                        if (cellOccupied)
                        {
                            columnOccupied = true;
                            occupied = true;
                        }
                    }
                } while (columnOccupied);
            }
            return occupied;
        }
        public bool moveCellsDown()
        {
            bool occupied = false;
            if (moveCellsDownLoop()) occupied = true;
            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = BOARD_SIZE - 1; columns > 0; columns--)
                {
                    int columnsPlus = columns - 1;
                    occupied = combineCells(rows, columnsPlus, rows, columns, occupied);
                }
            }
            if (moveCellsDownLoop()) occupied = true;
            return occupied;
        }
        private bool moveCellsDownLoop()
        {
            bool occupied = false;
            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                bool columnOccupied = false;
                do
                {
                    columnOccupied = false;
                    for (int columns = BOARD_SIZE - 1; columns > 0; columns--)
                    {
                        int columnsPlus = columns - 1;
                        bool cellOccupied = moveCell(rows, columnsPlus, rows, columns);
                        if (cellOccupied)
                        {
                            columnOccupied = true;
                            occupied = true;
                        }
                    }
                } while (columnOccupied);
            }
            return occupied;
        }
        public bool moveCellsLeft()
        {
            bool occupied = false;
            if (moveCellsLeftLoop()) occupied = true;
            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                for (int rows = 0; rows < (BOARD_SIZE - 1); rows++)
                {
                    int rowsPlus = rows + 1;
                    occupied = combineCells(rowsPlus, columns, rows, columns, occupied);
                }
            }
            if (moveCellsLeftLoop()) occupied = true;
            return occupied;
        }
        private bool moveCellsLeftLoop()
        {
            bool occupied = false;
            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                bool rowOccupied = false;
                do
                {
                    rowOccupied = false;
                    for (int rows = 0; rows < (BOARD_SIZE - 1); rows++)
                    {
                        int rowsPlus = rows + 1;
                        bool cellOccupied = moveCell(rowsPlus, columns, rows, columns);
                        if (cellOccupied)
                        {
                            rowOccupied = true;
                            occupied = true;
                        }
                    }
                } while (rowOccupied);
            }
            return occupied;
        }
        public bool moveCellsRight()
        {
            bool occupied = false;
            if (moveCellsRightLoop()) occupied = true;
            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                for (int rows = (BOARD_SIZE - 1); rows > 0; rows--)
                {
                    int rowsPlus = rows - 1;
                    occupied = combineCells(rowsPlus, columns, rows, columns, occupied);
                }
            }
            if (moveCellsRightLoop()) occupied = true;
            return occupied;
        }
        private bool moveCellsRightLoop()
        {
            bool occupied = false;
            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                bool rowOccupied = false;
                do
                {
                    rowOccupied = false;
                    for (int rows = (BOARD_SIZE - 1); rows > 0; rows--)
                    {
                        int rowsPlus = rows - 1;
                        bool cellOccupied = moveCell(rowsPlus, columns, rows, columns);
                        if (cellOccupied)
                        {
                            rowOccupied = true;
                            occupied = true;
                        }
                    }
                } while (rowOccupied);
            }
            return occupied;
        }
        private bool combineCells(int x1, int y1, int x2, int y2,
                bool occupied)
        {
            if (!gameBoard[x1, y1].isZeroValue())
            {
                int value = gameBoard[x1, y1].getValue();
                if (gameBoard[x2, y2].getValue() == value)
                {
                    int newValue = value + value;
                    gameBoard[x2, y2].setValue(newValue);
                    gameBoard[x1, y1].setZeroValue();
                    cellAddValue += newValue;
                    occupied = true;
                }
            }
            return occupied;
        }

        public int getScoreValue()
        {
            return cellAddValue;
        }
        private bool moveCell(int x1, int y1, int x2, int y2)
        {
            bool occupied = false;
            if (!gameBoard[x1, y1].isZeroValue()
                    && (gameBoard[x2, y2].isZeroValue()))
            {
                int value = gameBoard[x1, y1].getValue();
                gameBoard[x2, y2].setValue(value);
                gameBoard[x1, y1].setValue(0);
                occupied = true;
            }
            return occupied;
        }
    }

}


