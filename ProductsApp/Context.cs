using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsApp
{
    class DBTable

    {
        private DBConnection _DBConnection;
        private Dictionary<int, DBFields> _Table = new Dictionary<int, DBFields>();
        public DBTable(DBConnection DBConnection)

        {
            _DBConnection = DBConnection;
            UpdateNow();
        }

        public DBFields this[int Id]
        {
            get

            {
                if (!_Table.ContainsKey(Id))

                {
                    throw new NoKeyException();
                }

                return _Table[Id];
            }
        }
        
        public int[] Keys
        {
            get
            {
                int x;
                int unSorted = 0;
                var Array = _Table.Keys.ToArray();
                do
                {
                    unSorted = 0;
                    for (int i = 0; i < Array.Length - 1; i++)
                    {
                        if (Array[i] > Array[i + 1])
                        {
                            x = Array[i];
                            Array[i] = Array[i + 1];
                            Array[i + 1] = x;
                            unSorted++;
                        }
                    }
                }
                while (unSorted != 0);
                return Array;
            }

        }

        public int Count
        {

            get

            {
                return _Table.Count;
            }

        }

        public bool Add(int Id, string Category = "Sin Categoria", string Name = "Sin Nombre", decimal Price = 0)
        {
            if (_Table.ContainsKey(Id))

            {
                throw new DuplicateKeyException();
            }

            _Table.Add(Id, new DBFields(_DBConnection, Id, Category, Name));
            return _DBConnection.InsertRow(Id, "CategoriaProducto, NombreProducto, PrecioProducto", $"'{Category}', '{Name}', {Price}");
        }

        public bool Remove(int Id)
        {
            if (!_Table.ContainsKey(Id))

            {
                throw new NoKeyException();
            }

            _Table.Remove(Id);
            return _DBConnection.DeleteRow(Id);
        }

        public void UpdateNow()
        {
            _Table.Clear();
            foreach (int Id in _DBConnection.Keys)

            {
                _Table.Add(Id, new DBFields(_DBConnection, Id));
            }

        }

        public class DBFields
        {
            private DBConnection _DBConnection;
            private readonly int _Id;
            private string _Category = "";
            private string _Name = "";
            private decimal _Price = 0;
            private DateTime _LastModified = DateTime.Now;
            private bool _CategoryIsUpdate = false;
            private bool _NameIsUpdate = false;
            private bool _PriceIsUpdate = false;
            private bool _LastModifiedIsUpdate = false;
            internal DBFields(DBConnection DBConnection, int Id, string Category = "#NoData-?", string Name = "#NoData-?")

            {
                this._DBConnection = DBConnection;
                this._Id = Id;
                if (Category != "#NoData-?")

                {
                    this._Category = Category;
                    this._CategoryIsUpdate = true;
                }

                if (Name != "#NoData-?")
                {
                    this._Name = Name;
                    this._NameIsUpdate = true;
                }

            }

            public string Category
            {
                get

                {
                    if (_CategoryIsUpdate)

                    {
                        return _Category;
                    }

                    else
                    {
                        _Category = _DBConnection.GetString(_Id, "CategoriaProducto");
                        if ("#NoData-?" != _Category)

                        {
                            _CategoryIsUpdate = true;
                        }

                        return _Category;
                    }
                }

                set
                {
                    _DBConnection.SetField(_Id, "CategoriaProducto", value, true);
                    _CategoryIsUpdate = false;
                    _LastModifiedIsUpdate = false;
                }

            }

            public string Name
            {
                get

                {
                    if (_NameIsUpdate)

                    {
                        return _Name;
                    }

                    else
                    {
                        _Name = _DBConnection.GetString(_Id, "NombreProducto");
                        if ("#NoData-?" != _Name)

                        {
                            _NameIsUpdate = true;
                        }

                        return _Name;
                    }
                }

                set
                {
                    _DBConnection.SetField(_Id, "NombreProducto", value, true);
                    _NameIsUpdate = false;
                    _LastModifiedIsUpdate = false;
                }

            }

            public decimal Price
            {
                get

                {
                    if (_PriceIsUpdate)

                    {
                        return _Price;
                    }

                    else
                    {
                        _PriceIsUpdate = true;
                        return _Price = _DBConnection.GetDecimal(_Id, "PrecioProducto");
                    }

                }

                set
                {
                    _DBConnection.SetField(_Id, "PrecioProducto", value, true);
                    _PriceIsUpdate = false;
                    _LastModifiedIsUpdate = false;
                }

            }
            public string PriceString
            {
                set
                {
                    _DBConnection.SetField(_Id, "PrecioProducto", value, true);
                    _PriceIsUpdate = false;
                    _LastModifiedIsUpdate = false;
                }

            }

            public DateTime LastModified
            {
                get

                {
                    if (_LastModifiedIsUpdate)

                    {
                        return _LastModified;
                    }

                    else
                    {
                        _LastModifiedIsUpdate = true;
                        return _LastModified = _DBConnection.GetDateTime(_Id, "UltimaModificacionProducto");
                    }

                }
            }
        }
    }

    internal class DuplicateKeyException : Exception
    {
        public override string ToString()

        {
            return "Codigo duplicado";
        }

    }

    internal class NoKeyException : Exception
    {
        public override string ToString()

        {
            return "Codigo no existente";
        }

    }
}
