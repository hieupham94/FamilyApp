using System;
using Xamarin.Forms;

namespace FamilyApp
{
    class Class1 : ContentPage
    {
        public Class1()
        {
            Content = new Label
            {
                Text = "Greetings, Xamarin.Forms!",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                //FontAttributes = FontAttributes.Italic | FontAttributes.Bold,
                //FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                BackgroundColor = Color.Aqua,
                TextColor = Color.Red,
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "There are 4 people in my family." + Environment.NewLine,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        new Span
                        {
                            Text ="Myself" + Environment.NewLine,
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            FontAttributes = FontAttributes.Bold
                        },
                        new Span
                        {
                            Text = "My dad" + Environment.NewLine,
                            FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                            FontAttributes = FontAttributes.Bold
                        },
                        new Span
                        {
                            Text = "My mom" + Environment.NewLine,
                            FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                            FontAttributes = FontAttributes.Bold
                        },
                        new Span
                        {
                            Text = "My twin brother" + Environment.NewLine,
                            FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                            FontAttributes = FontAttributes.Bold
                        }
                    }
                }
            };
        }
    }
}
