namespace Datastruct
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<TType> : IStack<TType>, IEnumerable<TType>, IEnumerator<TType> where TType : struct
    {
        private int count;

        public Stack()
        {
        }

        public Stack(int size)
        {
            if (size > 0)
            {
                this.Nodes = new TType[size];
                this.count = 0;
            }
            else
            {
                throw new ArgumentOutOfRangeException(string.Format("Size parameter must be more than zero, actually parameter equals to {0}", size));
            }
        }

        private TType[] Nodes { get; set; }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        TType IEnumerator<TType>.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Size
        {
            get
            {
                return this.Nodes.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            private set
            {
                if (value < 0 || value > this.Size)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Count new value must be more than zero and less than {0}, actually parameter equals to {1}", this.Size, value));
                }

                this.count = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<TType> IEnumerable<TType>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Pop()
        {
            if (this.count == 0)
            {
                throw new IndexOutOfRangeException("Stack doesn't have nodes");
            }

            count--;
            this.Nodes[count] = default(TType);
        }

        public void Push(TType newNode)
        {
            if (this.count == this.Size)
            {
                throw new StackOverflowException(string.Format("Stack nodes count at the moment equals to size : {0}", this.Size));
            }

            this.Nodes[this.count] = newNode;
            count++;
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        public TType Top()
        {
            if (this.count == 0)
            {
                throw new IndexOutOfRangeException("Stack doesn't have nodes");
            }

            return this.Nodes[this.count - 1];
        }

        #region IDisposable Support

        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~Stack() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        void IDisposable.Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support

        public override string ToString()
        {
            string temp = string.Empty;
            //// Replace with foreach
            for (int i = 0; i < this.count; i++)
            {
                temp += string.Format("{0} ", this.Nodes[i]);
            }

            //// for the test
            return temp.Remove(temp.Length - 1, 1);
        }
    }
}