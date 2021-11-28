using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangQuanAo.DTO
{
    class LOAISP
    {
        /*
         CREATE TABLE LOAISP
        (
        	ID INT PRIMARY KEY IDENTITY(1,1),
        	TENLOAI NVARCHAR(20)
        )
         */
       private int iD;
       private string tenLoai;

        public LOAISP(int iD, string tenLoai)
        {
            this.iD = iD;
            this.tenLoai = tenLoai;
        }

        public int ID { get => iD; set => iD = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
