using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
    /// <summary>
    /// 有效的数独
    /// 判断一个 9x9 的数独是否有效。只需要根据以下规则，验证已经填入的数字是否有效即可。
    /// 数字 1-9 在每一行只能出现一次。
    /// 数字 1-9 在每一列只能出现一次。
    /// 数字 1-9 在每一个以粗实线分隔的 3x3 宫内只能出现一次。
    /// </summary>
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            IDictionary<int, HashSet<int>[]> map = new Dictionary<int, HashSet<int>[]>();
            if(board.Length == 0 || !board.Any())
            {
                return false;
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == '.'||!char.IsDigit(board[i][j]))
                        continue;
                    int box_index = (i / 3) * 3 + j / 3;
                    if (map.ContainsKey(board[i][j]))
                    {
                        if (map[board[i][j]][0].Contains(i)|| map[board[i][j]][1].Contains(j)||map[board[i][j]][2].Contains(box_index))
                        {
                            return false;
                        }
                        else
                        {
                            map[board[i][j]][0].Add(i);
                            map[board[i][j]][1].Add(j);
                            map[board[i][j]][2].Add(box_index);
                        }
                            
                    }
                    else
                    {
                        map.Add(board[i][j], new HashSet<int>[] { new HashSet<int> { i}, new HashSet<int> { j }, new HashSet<int> { box_index } });
                    }
                }
            }

            return true;
        }
    }
}
