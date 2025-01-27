namespace Menu_component
{
    public class MenuButton
    {
        public MenuButton(string buttonText, List<MenuItem> dropDownItems)
        {
            this.ButtonText = buttonText;
            this.Items = dropDownItems;
            // Sets arrow down symbol indicating that the button has children; otherwise, sets it to an empty string.
            this.ArrowDown = dropDownItems != null && dropDownItems.Count > 0 ? "▼" : string.Empty;
        }

        public string? ButtonText { get; init; }

        public List<MenuItem> Items { get; init; } = [];

        public string? ArrowDown { get; init; }
    }
}
