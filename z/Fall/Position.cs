using System;
using System.Collections;
using System.Collections.Generic;

namespace Fall
{
    public class Position : IEnumerable<Position>
    {
        private Position[] _positions;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool InGame { get; set; }
        public bool OutGame { get; set; }
        public int NumInGame { get; set; }
        public int NumOutGame { get; set; }
        public bool Taken { get; set; }
        public Figure figureOnPosition { get; set; }
        public List<Figure> lstFigure = new List<Figure>();

        public Position(Position[] pArray)
        {
            _positions = new Position[pArray.Length];
            for (int i = 0; i < pArray.Length; i++)
            {
                _positions[i] = pArray[i];
            }
        }

        public IEnumerator<Position> GetEnumerator()
        {
            return new PositionEnum(_positions);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class PositionEnum : IEnumerator<Position>
    {
        private Position[] _positions;
        private int position = -1;

        public PositionEnum(Position[] list)
        {
            _positions = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _positions.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current => Current;

        public Position Current
        {
            get
            {
                try
                {
                    return _positions[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        {
            // Implement this method if you need to release resources
        }
    }
}
