using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AcousticalModeling
{
    public class Materials
    {
        public string name = "";
        public double _htz125;
        public double _htz250;
        public double _htz500;
        public double _htz1k;
        public double _htz2k;
        public double _htz4k;

        public Materials(string Name, double htz125, double htz250, double htz500, double htz1k, double htz2k, double htz4k)
        {
           /*
            try
            {
                SqlConnect sq = new SqlConnect();
                SqlDataReader Data = sq.sqlMaterial(Name);

                foreach (SqlDataReader s in Data)
                {
                    if (s.HasRows)

                    {
                        _htz125 = (double)s["htz125"];
                        _htz250 = (double)s["htz250"];
                        _htz500 = (double)s["htz500"];
                        _htz1k = (double)s["htz1k"];
                        _htz2k = (double)s["htz2k"];
                        _htz4k = (double)s["htz4k"];


                    }
                }

            }
            catch ( Exception ex)
            {
                Console.Write("Error in the code" + ex.ToString()
                    );

            }

          */      _htz125 = htz125;
            _htz250 = htz250;
            _htz500 = htz500;
            _htz1k = htz1k;
            _htz2k = htz2k;
            _htz4k = htz4k;

            name = Name;
           
        }

       

    }
}
