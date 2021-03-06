﻿using MVP.Services.Interfaces;

namespace MVP.Pages
{
    public partial class WizardTitlePage
    {
        public WizardTitlePage(IAnalyticsService analyticsService)
            : base(analyticsService) => InitializeComponent();

        protected override void OnAppearing()
        {
            base.OnAppearing();
            entry.Focus();
        }
    }
}
