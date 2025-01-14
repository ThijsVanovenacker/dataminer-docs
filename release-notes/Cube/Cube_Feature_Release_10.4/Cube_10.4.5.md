---
uid: Cube_Feature_Release_10.4.5
---

# DataMiner Cube Feature Release 10.4.5 – Preview

> [!IMPORTANT]
> We are still working on this release. Some release notes may still be modified or moved to a later release. Check back soon for updates!

> [!TIP]
> For release notes for this release that are not related to DataMiner Cube, see [General Feature Release 10.4.5](xref:General_Feature_Release_10.4.5).

## Highlights

*No highlights have been selected yet.*

## New features

*No features have been added yet.*

## Changes

### Enhancements

#### Alarm Console: Newly opened suggestion events tab will now include 'Service impact', 'Services' and 'RCA level' columns by default [ID_38732]

<!-- MR 10.3.0 [CU14]/10.4.0 [CU2] - FR 10.4.5 -->

From now on, a newly opened suggestion events tab will include *Service impact*, *Services* and *RCA level* columns by default.

Also, from now on, when you right-click a column header and select *Add/Remove column > Set default columns* in a suggestion events tab, the default columns will be restored correctly. Up to now, selecting the *Set default columns* menu option would incorrectly restore the default columns of an active alarms tab instead.

#### Alarm Console: Enhanced performance when loading a large number of active alarms [ID_38808]

<!-- MR 10.3.0 [CU14]/10.4.0 [CU2] - FR 10.4.5 -->

Because of a number of enhancements, overall performance has increased when loading a large number of active alarms.

#### System Center - Agents: Tooltip of 'Upgrade only' button will now mention the prerequisites will be run [ID_38864]

<!-- MR 10.3.0 [CU14]/10.4.0 [CU2] - FR 10.4.5 -->

When, in the *Upgrade* window, you hover over the *Upload only* button, the following tooltip will now appear:

`Uploading a package with prerequisites will run those prerequisites on each Agent of the cluster.`

The same message will also be shown on the confirmation box that will appear after you click the *Upload only* button.

### Fixes

#### Resources app: Resource would incorrectly be marked as modified when capability values were set to NaN [ID_38699]

<!-- MR 10.3.0 [CU14]/10.4.0 [CU2] - FR 10.4.5 -->

In some cases, resource profiles generated within the Service & Resource Management solution would have their Min and Max capability values set to *NaN*. In the *Resources* app of Cube, a false positive result would then be returned when checking whether the capability of a resource had been changed.

From now on, when the *Resources* app of Cube detects that the Min and Max capability values of a resource profile are set to *NaN*, it will no longer mark the resource in question as modified.
