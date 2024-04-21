namespace MudBlazorTreeViewReorder.Data
{
    public class TreeItem
    {
        public TreeItem(string text, string parentId = null)
        {
            Text = text;
            ParentID = parentId;
            ID = GenerateID();
        }
        public string Text { get; set; }
        public bool Expanded { get; set; }
        public bool IsSelected { get; set; }
        public string ParentID { get; set; }
        public string ID { get; set; }
        public DragDropAction DropAction { get; set; }

        private string GenerateID()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public enum DragDropAction
    {
        None,
        Above,
        Inside,
        Below,
        Error
    }
}
