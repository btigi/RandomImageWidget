// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Windows.Widgets.Providers;
using System;
using System.IO;
using System.Text.Json.Nodes;

namespace RandomImageWidgetProvider
{
    internal class RandomImageWidget : WidgetImplBase
    {
        public static string DefinitionId { get; } = "Random_Image_Widget";
        public RandomImageWidget(string widgetId, string startingState) : base(widgetId, startingState)
        {
            return;
        }

        public override void OnActionInvoked(WidgetActionInvokedArgs actionInvokedArgs)
        {
            return;
        }

        public override void OnWidgetContextChanged(WidgetContextChangedArgs contextChangedArgs)
        {
            return;
        }

        public override void Activate(WidgetContext widgetContext)
        {
            // Activate doesn't seem to get called
            isActivated = true;
        }

        public override void Deactivate()
        {
            // As activate doesn't seem to get called we'll update the image each time the widget is hidden, rather than each time it is displayed
            var updateOptions = new WidgetUpdateRequestOptions(Id);
            updateOptions.Data = GetDataForWidget();
            updateOptions.CustomState = State;
            WidgetManager.GetDefault().UpdateWidget(updateOptions);

            isActivated = false;
        }

        private static string GetDefaultTemplate()
        {
            if (string.IsNullOrEmpty(WidgetTemplate))
            {
                WidgetTemplate = ReadPackageFileFromUri("ms-appx:///Templates/RandomImageWidgetTemplate.json");
            }

            return WidgetTemplate;
        }

        public override string GetTemplateForWidget()
        {
            return GetDefaultTemplate();
        }

        public override string GetDataForWidget()
        {
            var filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "images.txt");

            var lines = File.ReadAllLines(filepath);
            var random = new Random();
            var randomIndex = random.Next(lines.Length);
            var randomEntry = lines[randomIndex];

            var stateNode = new JsonObject {
                ["imageUrl"] = randomEntry
            };
            Console.WriteLine(stateNode.ToString());
            return stateNode.ToJsonString();
        }

        private static string WidgetTemplate { get; set; } = "";
    }
}