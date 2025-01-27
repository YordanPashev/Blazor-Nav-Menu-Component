namespace Menu_component
{
    public class MenuItem
    {
        public string? Text { get; init; }

        public List<MenuItem> Children { get; init; } = [];

        /// <summary>
        /// Gets the arrow symbol indicating that the button has children.
        /// An arrow pointing to the right will be displayed after the item text if the button has children.
        /// </summary>
        public string? ArrowRight => Children != null && this.Children.Count > 0 ? "▶" : string.Empty;
    }
}
