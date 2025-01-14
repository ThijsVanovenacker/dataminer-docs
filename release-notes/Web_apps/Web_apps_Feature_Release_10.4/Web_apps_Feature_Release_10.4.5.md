---
uid: Web_apps_Feature_Release_10.4.5
---

# DataMiner web apps Feature Release 10.4.5 – Preview

> [!IMPORTANT]
> We are still working on this release. Some release notes may still be modified or moved to a later release. Check back soon for updates!

> [!TIP]
> For release notes for this release that are not related to the web applications, see [General Feature Release 10.4.5](xref:General_Feature_Release_10.4.5).

## Highlights

*No highlights have been selected yet.*

## New features

#### Dashboards app & Low-Code Apps: Client metric logging [ID_39000]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

In the `C:\Skyline DataMiner\Logging\Web` folder, apart from Web API logging, you can now also find client metric logging.

Client metric logging is employed to record different performance and issue indicators of clients connecting to Dashboards and Low-Code Apps. These logs encompass everything from unexpected errors to the load time of a dashboard or low-code app page. This logging data is stored in the `Client` subfolder of the web logs.

> [!TIP]
> For more information, see [Dashboards and Low-Code Apps logging](xref:Dashboards_and_Low_Code_Apps_Logging).

## Changes

### Breaking changes

#### Low-Code Apps: Parameters of a script action linked to an empty feed will now be filled with an empty array [ID_39027]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

Up to now, when a script parameter of a *Launch a script* action was linked to a feed, that parameters would be set to null when the feed was empty.

From now on, linking a script parameter to an empty feed will fill it with an empty array instead. The dialog to manually enter a parameter will no longer be shown when the action is launched. This change can break existing implementations when it is not handled by the script.

### Enhancements

#### Dashboards app & Low-Code Apps - Query filter component: Enhanced button coloring [ID_38754]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

Up to now, the buttons in the *Query filter* component would be barely visible when the color of the app was similar to the background color of the theme. From now on, the buttons in the *Query filter* component will always have the text color of the theme.

#### Web apps: Enhanced performance when starting up [ID_38999]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

Because of a number of enhancements, overall performance has increased when starting up a DataMiner web app.

#### Landing page - Other apps: No longer possible to right-click apps on mobile devices [ID_39036]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

When you open the landing page of a DataMiner Agent (e.g. `https://myDMA/root/`) on a mobile device, it will no longer be possible to open the context menu of apps listed in the *Other apps* section.

### Fixes

#### Dashboards app & Low-Code Apps - Dropdown component: Filter would no longer be applied after losing the focus [ID_38834]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

When a *Dropdown* component with a filter applied lost the focus, the moment it had the focus again, the filter would no longer be applied.

#### Dashboards app: Problem with Dropdown components on shared dashboards [ID_38953]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

When, on a shared dashboard, a *Dropdown* component had a time range or service definition filter applied, it would not be possible to use that component.

#### Web apps: Context menu would not close when scrolling on a mobile device [ID_38992]

<!-- MR 10.3.0 [CU14] / 10.4.0 [CU2] - FR 10.4.5 -->

When, on a mobile device, you scrolled while a context menu was open, that context menu would incorrectly not close.
