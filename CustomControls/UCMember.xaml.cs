using System.Windows.Controls;

namespace CustomControls;

public partial class UCMember : UserControl
{
    public UCMember()
    {
        InitializeComponent();
        this.DataContext = this;
    }

    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string URL { get; set; }
}