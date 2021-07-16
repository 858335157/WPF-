
using System.Collections.Generic;

namespace ShowMeTheXAML
{
    public static class XamlDictionary
    {
        static XamlDictionary()
        {
            XamlResolver.Set("dialogs_sample4", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample4"" Margin=""8 8 0 0"" Grid.Column=""3"" Grid.Row=""1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DialogHost VerticalAlignment=""Center"" IsOpen=""{Binding IsSample4DialogOpen}"" DialogContent=""{Binding Sample4Content}"" CloseOnClickAway=""True"" OverlayBackground=""{DynamicResource PrimaryHueDarkBrush}"" DialogTheme=""Inherit"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Border BorderThickness=""1"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" MinWidth=""256"" MinHeight=""256"" ClipToBounds=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Button HorizontalAlignment=""Center"" VerticalAlignment=""Center"" Command=""{Binding OpenSample4DialogCommand}"" Content=""RUN"" />
    </Border>
  </materialDesign:DialogHost>
</smtx:XamlDisplay>");
        }
    }
}