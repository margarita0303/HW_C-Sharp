using System;
using System.Collections.Generic;
using System.Threading;

namespace Sudoku
{
    public class CheckSudoku
    {
        private char[,] _table;
        private bool _isRightHorizontally = true;
        private bool _isRightVertically = true;
        private bool _isRightInSquares = true;
        
        public CheckSudoku(char [,] table)
        {
            _table = table;
        }
        
        public bool Check()
        {
            Thread myThread1 = new Thread(new ThreadStart(CheckHorizontally));
            myThread1.Start();
            myThread1.Join();

            Thread myThread2 = new Thread(new ThreadStart(CheckVertically));
            myThread2.Start();
            myThread2.Join();

            Thread myThread3 = new Thread(new ThreadStart(CheckInSquares));
            myThread3.Start();
            myThread3.Join();
            
            return _isRightHorizontally && _isRightVertically && _isRightInSquares;
        }

        private void CheckInSquares()
        {
            for (var i = 0; i < 9; i+=3)
            {
                for (var j = 0; j < 9; j+=3)
                {
                    HashSet<int> ss = new HashSet<int>();
                    for(var i2 = i; i2 < i + 3; i2++)
                    {
                        for (var j2 = j; j2 < j + 3; j2++)
                        {
                            if (_table[i, j] == ',')
                            {
                                continue;
                            }
                            if (ss.Contains(_table[i2, j2]))
                            {
                                _isRightInSquares = false;
                            }
                        }
                    }
                }
            }
        }

        private void CheckHorisonralOrVertical(bool isHorisontal)
        {
            for (var i = 0; i < 9; i++)
            {
                HashSet<char> ss = new HashSet<char>();
                for (var j = 0; j < 9; j++)
                {
                    if (_table[i, j] == ',')
                    {
                        continue;
                    }
                    if (isHorisontal && ss.Contains(_table[i, j]))
                    {
                        _isRightHorizontally = false;
                        break;
                    }
                    
                    if (!isHorisontal && ss.Contains(_table[j, i]))
                    {
                        _isRightVertically = false;
                        break;
                    }
                    ss.Add(_table[i,j]);
                }
            }
        }


        private void CheckHorizontally()
        { 
            for (var i = 0; i < 9; i++)
            {
                HashSet<char> ss = new HashSet<char>();
                for (var j = 0; j < 9; j++)
                {
                    if (_table[i, j] == '.')
                    {
                        continue;
                    }
                    if (ss.Contains(_table[i, j]))
                    {
                        Console.WriteLine("Stop " + _table[i, j]);
                        _isRightHorizontally = false;
                        break;
                    }
                    ss.Add(_table[i, j]);
                }
            }
        }

        private void CheckVertically()
        {
            for (var i = 0; i < 9; i++)
            {
                HashSet<char> ss = new HashSet<char>();
                for (var j = 0; j < 9; j++)
                {
                    if (_table[j, i] == '.')
                    {
                        continue;
                    }
                    if (ss.Contains(_table[j, i]))
                    {
                        _isRightHorizontally = false;
                        break;
                    }
                    ss.Add(_table[j, i]);
                }
            }
        }
    }
}
