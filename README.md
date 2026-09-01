# How to create grouped ListView in .NET MAUI?
This example describes how to create grouped ListView(SfListView) in .NET MAUI.

**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13069/how-to-create-a-grouped-listview-in-net-maui-sflistview)**

## Sample

```xaml
<ListView:SfListView x:Name="listView"
                        ItemSize="70" GroupHeaderSize="50"
                        SelectionMode="Single"
                        IsStickyGroupHeader="True"
                        ItemsSource="{Binding ContactsInfo}"
                        AllowGroupExpandCollapse="True"
                        >

    <ListView:SfListView.BindingContext>
        <local:ViewModel />
    </ListView:SfListView.BindingContext>

    <ListView:SfListView.DataSource>
        <data:DataSource>
            <data:DataSource.SortDescriptors>
                <data:SortDescriptor PropertyName="ContactName" Direction="Ascending" />
            </data:DataSource.SortDescriptors>
        </data:DataSource>
    </ListView:SfListView.DataSource>

    <ListView:SfListView.GroupHeaderTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </ListView:SfListView.GroupHeaderTemplate>

    <ListView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </ListView:SfListView.ItemTemplate>
</ListView:SfListView>

C#:

ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
    PropertyName = "ContactName",
    KeySelector = (object obj1) =>
    {
        var item = (obj1 as ListViewContactInfo);
        return item.ContactName[0].ToString();
    },
});
```
