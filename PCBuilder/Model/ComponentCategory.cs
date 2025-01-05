namespace PCBuilder.Model
{
    public class ComponentCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string IconClass { get; set; }
        public Component? SelectedComponent { get; set; }
        public List<Component> Options { get; set; } = new List<Component>();
    }
}
