using HTML_Editor.Views;

namespace HTML_Editor
{
    public class TestInstance
    {
        DrawLines drawLines = new DrawLines();
        DrawPlus drawPlus = new DrawPlus();
        DrawFinal drawFinal = new DrawFinal();
        WriteOptions writeOptions = new WriteOptions();
        Editor editor = new Editor();

        public DrawLines DrawLines { get => drawLines; set => drawLines = value; }
        public DrawPlus DrawPlus { get => drawPlus; set => drawPlus = value; }
        public DrawFinal DrawFinal { get => drawFinal; set => drawFinal = value; }
        public WriteOptions WriteOptions { get => writeOptions; set => writeOptions = value; }
        public Editor Editor { get => editor; set => editor = value; }
    }
}
