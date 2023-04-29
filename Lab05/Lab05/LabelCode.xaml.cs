using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelCode : ContentPage
    {
        public LabelCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var underlineLabel = new Label {
                Text = "This is underlined text.",
                TextDecorations = TextDecorations.Underline
            };
            var strikethroughtLabel = new Label
            {
                Text = "This is text with strikethrought.",
                TextDecorations = TextDecorations.Strikethrough
            };
            var bothLabel = new Label
            {
                Text = "This is underlined text with strikethrought.",
                TextDecorations = TextDecorations.Underline | TextDecorations.Strikethrough
            };

            stack.Children.Add(underlineLabel);
            stack.Children.Add(strikethroughtLabel);
            stack.Children.Add(bothLabel);
            Content = stack;

        }
    }
}