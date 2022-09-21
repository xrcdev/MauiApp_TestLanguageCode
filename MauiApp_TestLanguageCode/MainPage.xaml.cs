using Microsoft.Maui.Controls.Shapes;
using System.Globalization;
using System.Text;

namespace MauiApp_TestLanguageCode;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
		/*
		
		<html>
<body>

<table border="1">
 
</table>

</body>
</html>
		
		
		*/
        var cInfos = CultureInfo.GetCultures(CultureTypes.NeutralCultures | CultureTypes.SpecificCultures |
            CultureTypes.InstalledWin32Cultures | CultureTypes.UserCustomCulture |
            CultureTypes.ReplacementCultures | CultureTypes.WindowsOnlyCultures |
        CultureTypes.FrameworkCultures);

        CultureInfo cultureInfo = CultureInfo.CurrentCulture;
        var trHeader = $"<tr><th>{nameof(cultureInfo.LCID)}</th><th>{nameof(cultureInfo.ThreeLetterISOLanguageName)}</th><th>{nameof(cultureInfo.ThreeLetterWindowsLanguageName)}</th><th>{nameof(cultureInfo.Name)}</th><th>{nameof(cultureInfo.EnglishName)}</th><th>{nameof(cultureInfo.NativeName)}</th><th>{nameof(cultureInfo.DisplayName)}</th></tr>";
       
        System.Diagnostics.Debug.WriteLine(trHeader);
        foreach (var item in cInfos.OrderBy(t => t.LCID))
        {
          
            var line=$"<td>{item.LCID}</td>,<td>{item.ThreeLetterISOLanguageName}</td>,<td>{item.ThreeLetterWindowsLanguageName}</td>,<td>{item.Name}</td>,<td>{item.EnglishName}</td>,<td>{item.NativeName}</td>,<td>{item.DisplayName}</td>" ;
            System.Diagnostics.Debug.WriteLine($"<tr>{line}</tr>");
        }


        Console.WriteLine(cultureInfo.LCID);

        CultureInfo cultureInfo2 = new CultureInfo("zh-Hans-CN");
        Console.WriteLine(cultureInfo2.LCID);



        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

