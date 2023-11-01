using System.Runtime.Serialization.Formatters;

namespace UkazkoveMVC.Models
{
    public class NasobilkaXY
    {
        public List<List<int>> Rows { get; set; } 
                = new List<List<int>>();   
        
        public NasobilkaXY(int size) 
        {
            for(int i = 0;  i < size; i++)
            {
                List<int> row = new List<int>();

                for(int j = 0; j < size; j++)
                {
                    row.Add( ((i + 1) * (j + 1)) );
                }

                Rows.Add(row);
            }
        }

    }
}
