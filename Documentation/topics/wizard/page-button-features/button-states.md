---
title: "Button States"
page-title: "Button States - Wizard Page and Button Features"
order: 4
---
# Button States

Wizard allows total control over its button visibility and enabled states at both a global wizard level and at a page-specific override level.

Global settings made on the [Wizard](xref:@ActiproUIRoot.Controls.Wizard.Wizard) control are default settings for all contained pages.  Settings made on a [WizardPage](xref:@ActiproUIRoot.Controls.Wizard.WizardPage) can choose to inherit the global [Wizard](xref:@ActiproUIRoot.Controls.Wizard.Wizard) settings or override them with page-specific settings.  The page-specific settings take effect while that particular page is selected.

These settings are used by the Wizard [command model](../navigation-features/command-model.md) to determine whether the associated commands should be enabled.  See that topic for more information on how to use the commands.

## Wizard Global Default Button State Settings

These [Wizard](xref:@ActiproUIRoot.Controls.Wizard.Wizard) properties are used as the default settings for all pages within the Wizard:

| Member | Description |
|-----|-----|
| [HelpButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.Wizard.HelpButtonVisible) Property | A `Boolean` that indicates whether the **Help** button is visible. |
| [CancelButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.Wizard.CancelButtonVisible) Property | A `Boolean` that indicates whether the **Cancel** button is visible. |
| [BackButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.Wizard.BackButtonVisible) Property | A `Boolean` that indicates whether the **Back** button is visible. |
| [NextButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.Wizard.NextButtonVisible) Property | A `Boolean` that indicates whether the **Next** button is visible. |
| [FinishButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.Wizard.FinishButtonVisible) Property | A `Boolean` that indicates whether the **Finish** button is visible. |
| [HelpButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.Wizard.HelpButtonEnabled) Property | A `Boolean` that indicates whether the **Help** button is enabled. |
| [CancelButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.Wizard.CancelButtonEnabled) Property | A `Boolean` that indicates whether the **Cancel** button is enabled. |
| [BackButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.Wizard.BackButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Back** button is enabled.  A `true` or `false` value sets the Wizard default.  Specifying `null` uses the enabled logic for the [PreviousPage](xref:@ActiproUIRoot.Controls.Wizard.WizardCommands.PreviousPage) command as described in the [command model](../navigation-features/command-model.md) topic. |
| [NextButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.Wizard.NextButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Next** button is enabled.  A `true` or `false` value sets the Wizard default.  Specifying `null` uses the enabled logic for the [NextPage](xref:@ActiproUIRoot.Controls.Wizard.WizardCommands.NextPage) command as described in the [command model](../navigation-features/command-model.md) topic. |
| [FinishButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.Wizard.FinishButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Finish** button is enabled.  A `true` or `false` value sets the Wizard default.  Specifying `null` uses the enabled logic for the [Finish](xref:@ActiproUIRoot.Controls.Wizard.WizardCommands.Finish) command as described in the [command model](../navigation-features/command-model.md) topic. |

## WizardPage Instance Button State Settings

These [WizardPage](xref:@ActiproUIRoot.Controls.Wizard.WizardPage) properties are used as page-specific settings that may override the Wizard global settings:

| Member | Description |
|-----|-----|
| [HelpButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.HelpButtonVisible) Property | A nullable `Boolean` that indicates whether the **Help** button is visible.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [CancelButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.CancelButtonVisible) Property | A nullable `Boolean` that indicates whether the **Cancel** button is visible.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [BackButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.BackButtonVisible) Property | A nullable `Boolean` that indicates whether the **Back** button is visible.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [NextButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.NextButtonVisible) Property | A nullable `Boolean` that indicates whether the **Next** button is visible.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [FinishButtonVisible](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.FinishButtonVisible) Property | A nullable `Boolean` that indicates whether the **Finish** button is visible.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [HelpButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.HelpButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Help** button is enabled.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [CancelButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.CancelButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Cancel** button is enabled.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [BackButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.BackButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Back** button is enabled.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [NextButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.NextButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Next** button is enabled.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |
| [FinishButtonEnabled](xref:@ActiproUIRoot.Controls.Wizard.WizardPage.FinishButtonEnabled) Property | A nullable `Boolean` that indicates whether the **Finish** button is enabled.  A `true` or `false` value overrides the Wizard default.  Specifying `null` uses the Wizard default. |

## Setting At Run-Time

All of these properties may be changed at run-time programmatically to update the user interface button states.
