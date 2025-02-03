using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach
{
    public class listSach
    {
       
        public static listSach instance;
        List<Sach> listBook;
        public List<Sach> ListBook { get => listBook; set => listBook = value; }
        public static listSach Instance
        {
            get
            {
                if (instance == null)
                    instance = new listSach();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private listSach()
        {
            ListBook = new List<Sach>();
            ListBook.Add(new Sach("Sach1", "TacGia1", "Tiểu thuyết", "Tiếng Anh"));
            ListBook.Add(new Sach("Sach2", "TacGia2", "Kinh tế", "Tiếng Anh"));
            ListBook.Add(new Sach("Sach3", "TacGia3", "Khoa học", "Tiếng Pháp"));
        }
    }
    }

