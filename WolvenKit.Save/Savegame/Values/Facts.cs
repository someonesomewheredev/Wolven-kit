using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CSerializable("facts")]
    public class Facts
    {
        [CArray]
        public Fact[] Items { get; set; }
    }
}