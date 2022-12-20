using System;

namespace Duett_Server_Domain.Models.DTOS
{

    public class ListItemDTO
    {
        public ListItemDTO(string id, string description, int a, int b)
        {
            this.id = id;
            this.description = description;
            this.a = a;
            this.b = b;
        }

        public string id { get; set; }
        public string description { get; set; }
        public int a { get; set; }
        public int b { get; set; }
    }
}