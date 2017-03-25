﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Map<T> : List<List<T>>
    {
        public Map(int rows, int cols)
        {
            var oneRow = Enumerable.Repeat(default(T), cols);
            for (int i = 0; i < rows; i++)
                this.Add(oneRow.ToList());
        }

        public static Map<T> ParseMap<T>(List<string> data, Func<char, T> parseField)
        {
            Map<T> map = new Map<T>(data.Count, data[0].Length);

            for (int i = 0; i < map.Rows; i++)
            {
                var curRow = data[i];
                for (int i2 = 0; i2 < map.Cols; i2++)
                {
                    map[i][i2] = parseField(curRow[i2]);
                }
            }
            return map;
        }

        public int Rows
        {
            get { return this.Count; }
        }

        public int Cols
        {
            get { return this[0].Count; }
        }
    }

    public enum Moves4
    {
        Up, Left, Down, Right
    }

    public static class Moves
    {
        public static IEnumerable<Moves4> All4()
        {
            return new[] { Moves4.Up, Moves4.Left, Moves4.Down, Moves4.Right };
        }

        public static GridPoint Move(this Moves4 d, GridPoint point)
        {
            if (d == Moves4.Up)
                return new GridPoint(point.X, point.Y - 1);
            if (d == Moves4.Down)
                return new GridPoint(point.X, point.Y + 1);
            if (d == Moves4.Left)
                return new GridPoint(point.X - 1, point.Y);

            return new GridPoint(point.X + 1, point.Y);
        }
    }
}