using System;
namespace DemoPicker.Model
{
    public class EntityItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public override string ToString() => Title;
    }
}
