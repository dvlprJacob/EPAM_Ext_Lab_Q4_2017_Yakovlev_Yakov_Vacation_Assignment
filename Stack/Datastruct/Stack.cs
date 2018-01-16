namespace Datastruct
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<TType> : IStack<TType>, IEnumerable<TType>, IEnumerator<TType> where TType : struct, ICloneable, IDisposable
    {
        public Stack()
        {
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

        int IStack<TType>.Size
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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

        void IStack<TType>.Pop()
        {
            throw new NotImplementedException();
        }

        void IStack<TType>.Push(TType newNode)
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        TType IStack<TType>.Top()
        {
            throw new NotImplementedException();
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
    }
}