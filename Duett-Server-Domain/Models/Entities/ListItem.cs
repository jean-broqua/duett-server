using System;

namespace Duett_Server_Domain.Models.Entities
{
    public class ListItem : Entity
    {
        public string Description { get; private set; }
        public int AValue { get; private set; }

        public int BValue { get; private set; }

        public ListItem(string description, int aValue, int bValue)
        {
            ValidateDescription(description);
            Description = description;
            AValue = aValue;
            BValue = bValue;
        }

        protected ListItem()
        {
            // For EF Only
        }

        public void SetBValue(int value)
        {
            BValue = value;
        }

        public void SetAValue(int value)
        {
            AValue = value;
        }

        private void ValidateDescription(string description)
        {
            if (description.Length < 3)
            {
                throw new ArgumentException("Description should have at least 3 characters");
            }
        }
    }
}