using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_ValueTypes
{
    public class TShirt
    {
        public Size Size { get; }
        public string Color { get; }
        public DateTime CreationDateTime { get; }
        public DateTime? SentDateTime { get; set; }

        public TShirt(Size size, string color, DateTime creationDateTime)
        {
            Size = size;
            Color = color;
            CreationDateTime = creationDateTime;
        }

        public bool IsSent
        {
            get { return SentDateTime.HasValue; }
        }

        public override string ToString()
        {
            return $"{Size.ToString()} {Color} {CreationDateTime} {SentDateTime}";
        }
    }
}
