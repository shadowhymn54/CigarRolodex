using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;


namespace CigarRolodex {
    class Report {

        public void TopRating() {
            string rating = Interaction.InputBox("Enter the lowest rating to include (1-5)", "Rating", "3");
            rating = ValidateRating(rating);
            string topQuerySql = string.Format(@"SELECT [rating], [brand], [name], [style], [price], [count] FROM cigars WHERE [rating] >= {0} ORDER BY [rating] DESC;", rating);
            cmd = new SqlCeCommand(topQuerySql, con);
            con.Open();
            SqlCeDataReader reader = cmd.ExecuteReader();

            using(StreamWriter writer = new StreamWriter(@"C:\Top_Cigar_List.xls")) {
                writer.WriteLine("Rating\tBrand\tName\tSytle\tPrice\tQty");
                while(reader.Read()) {
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                        reader["Rating"], reader["Brand"], reader["Name"], reader["Style"], reader["Price"], reader["Count"]);
                }
            }
            con.Close();
        }

        private string ValidateRating(string rating) {
            for (int x = 0; x < 2; x++) {
                bool valid = false;
                for (int i = 1; i < 6; i++) {
                    if (i.ToString() == rating) {
                        valid = true;
                        break;
                    }
                }
                if (valid == false) {
                    MessageBox.Show(rating + " is not a valid rating between 1-5. The rating will be set to 3.", "Error");
                    rating = "3";
                }
            }
            return rating;
        }

        public void LowToHighPrice() {
            cmd = new SqlCeCommand(@"SELECT [rating], [brand], [name], [style], [price], [count] FROM cigars ORDER BY [price] ASC", con);
            con.Open();
            SqlCeDataReader reader = cmd.ExecuteReader();

            using (StreamWriter writer = new StreamWriter(@"C:\Cigars_By_Price.xls")) {
                writer.WriteLine("Rating\tBrand\tName\tStyle\tPrice\tQty");
                while (reader.Read()) {
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                        reader["Rating"], reader["Brand"], reader["Name"], reader["Style"], reader["Price"], reader["Count"]);
                }
            }
            con.Close();
        }

            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.cigarListConnection);
            SqlCeCommand cmd = new SqlCeCommand();
    }
}
