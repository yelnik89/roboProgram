
public class Rootobject
{
    public Remoteservicebindings remoteServiceBindings { get; set; }
    public string valueStream { get; set; }
    public Aspects aspects { get; set; }
    public Designtimepermissions designTimePermissions { get; set; }
    public string description { get; set; }
    public Effectivealertconfiguration effectiveAlertConfiguration { get; set; }
    public string thingTemplate { get; set; }
    public Effectiveshape effectiveShape { get; set; }
    public string enabled { get; set; }
    public Effectiveremoteeventbindings effectiveRemoteEventBindings { get; set; }
    public Implementedshapes implementedShapes { get; set; }
    public string effectiveThingPackage { get; set; }
    public Effectiveremotepropertybindings effectiveRemotePropertyBindings { get; set; }
    public Effectiveimplementedshapes effectiveImplementedShapes { get; set; }
    public Effectiveremoteservicebindings effectiveRemoteServiceBindings { get; set; }
    public Configurationtables228 configurationTables { get; set; }
    public Owner owner { get; set; }
    public string identifier { get; set; }
    public long lastModifiedDate { get; set; }
    public Visibilitypermissions visibilityPermissions { get; set; }
    public string homeMashup { get; set; }
    public string avatar { get; set; }
    public bool published { get; set; }
    public Effectivelocalpropertybindings effectiveLocalPropertyBindings { get; set; }
    public Remoteeventbindings remoteEventBindings { get; set; }
    public object[] tags { get; set; }
    public Remotepropertybindings remotePropertyBindings { get; set; }
    public Thingshape thingShape { get; set; }
    public string documentationContent { get; set; }
    public Runtimepermissions runTimePermissions { get; set; }
    public Propertybindings propertyBindings { get; set; }
    public string name { get; set; }
    public Alertconfigurations alertConfigurations { get; set; }
    public Configurationtabledefinitions configurationTableDefinitions { get; set; }
    public string projectName { get; set; }
    public Thingproperties thingProperties { get; set; }
}

public class Remoteservicebindings
{
}

public class Aspects
{
}

public class Designtimepermissions
{
    public object[] Read { get; set; }
    public object[] Delete { get; set; }
    public object[] Create { get; set; }
    public object[] Metadata { get; set; }
    public object[] Update { get; set; }
}

public class Effectivealertconfiguration
{
    public object[] led1 { get; set; }
    public object[] led2 { get; set; }
    public object[] led3 { get; set; }
    public object[] led4 { get; set; }
}

public class Effectiveshape
{
    public Propertydefinitions propertyDefinitions { get; set; }
    public Subscriptions subscriptions { get; set; }
    public Eventdefinitions eventDefinitions { get; set; }
    public Serviceimplementations serviceImplementations { get; set; }
    public Servicemappings serviceMappings { get; set; }
    public Servicedefinitions serviceDefinitions { get; set; }
}

public class Propertydefinitions
{
    public Led1 led1 { get; set; }
    public Led2 led2 { get; set; }
    public Name name { get; set; }
    public Description description { get; set; }
    public Led3 led3 { get; set; }
    public Led4 led4 { get; set; }
    public Thingtemplate thingTemplate { get; set; }
    public Tags tags { get; set; }
}

public class Led1
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects1 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects1
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Led2
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects2 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects2
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Name
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects3 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects3
{
    public bool isReadOnly { get; set; }
    public bool isPersistent { get; set; }
    public bool isBuiltIn { get; set; }
}

public class Description
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects4 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects4
{
    public bool isReadOnly { get; set; }
    public bool isPersistent { get; set; }
    public bool isBuiltIn { get; set; }
}

public class Led3
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects5 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects5
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Led4
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects6 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects6
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Thingtemplate
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects7 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects7
{
    public bool isReadOnly { get; set; }
    public bool isPersistent { get; set; }
    public bool isBuiltIn { get; set; }
}

public class Tags
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects8 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects8
{
    public bool isReadOnly { get; set; }
    public bool isPersistent { get; set; }
    public string tagType { get; set; }
    public bool isBuiltIn { get; set; }
}

public class Subscriptions
{
}

public class Eventdefinitions
{
    public Anyalertack AnyAlertAck { get; set; }
    public Anomalymonitorstatus AnomalyMonitorStatus { get; set; }
    public Anydatachange AnyDataChange { get; set; }
    public Alertreset AlertReset { get; set; }
    public Anyalertreset AnyAlertReset { get; set; }
    public Datachange DataChange { get; set; }
    public Alert Alert { get; set; }
    public Anyalert AnyAlert { get; set; }
    public Anyanomalymonitorstatus AnyAnomalyMonitorStatus { get; set; }
    public Thingstart ThingStart { get; set; }
    public Alertack AlertAck { get; set; }
}

public class Anyalertack
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects9 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects9
{
}

public class Anomalymonitorstatus
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects10 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects10
{
}

public class Anydatachange
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects11 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects11
{
}

public class Alertreset
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects12 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects12
{
}

public class Anyalertreset
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects13 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects13
{
}

public class Datachange
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects14 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects14
{
}

public class Alert
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects15 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects15
{
}

public class Anyalert
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects16 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects16
{
}

public class Anyanomalymonitorstatus
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects17 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects17
{
}

public class Thingstart
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects18 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects18
{
    public string auditMessageKey { get; set; }
    public string auditCategoryKey { get; set; }
}

public class Alertack
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects19 aspects { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string dataShape { get; set; }
}

public class Aspects19
{
}

public class Serviceimplementations
{
    public Setlocalpropertybinding SetLocalPropertyBinding { get; set; }
    public Getbooleanpropertyvalue GetBooleanPropertyValue { get; set; }
    public Getdesigntimepermissions GetDesignTimePermissions { get; set; }
    public Getvaluestream GetValueStream { get; set; }
    public Setmultirowconfigurationtable SetMultiRowConfigurationTable { get; set; }
    public Addnumbervaluestreamentry AddNumberValueStreamEntry { get; set; }
    public Queryvec2propertyhistory QueryVec2PropertyHistory { get; set; }
    public Addeventdefinition AddEventDefinition { get; set; }
    public Getvisibilitypermissions GetVisibilityPermissions { get; set; }
    public Purgeallpropertyhistory PurgeAllPropertyHistory { get; set; }
    public Addlocationvaluestreamentry AddLocationValueStreamEntry { get; set; }
    public Addvec3valuestreamentry AddVec3ValueStreamEntry { get; set; }
    public Getruntimepermissions GetRunTimePermissions { get; set; }
    public Getvec3propertyvalue GetVec3PropertyValue { get; set; }
    public Getmetadataasjson GetMetadataAsJSON { get; set; }
    public Removeremoteservicebinding RemoveRemoteServiceBinding { get; set; }
    public Getthingsummaryinformation GetThingSummaryInformation { get; set; }
    public Getalertdefinitions GetAlertDefinitions { get; set; }
    public Checkpermissionforuser CheckPermissionForUser { get; set; }
    public Acknowledgeallalerts AcknowledgeAllAlerts { get; set; }
    public Getimagepropertyvalue GetImagePropertyValue { get; set; }
    public Setpublished SetPublished { get; set; }
    public Getoutgoingdependencies GetOutgoingDependencies { get; set; }
    public Querystringpropertyhistory QueryStringPropertyHistory { get; set; }
    public Getalertstatuses GetAlertStatuses { get; set; }
    public Getpublished GetPublished { get; set; }
    public Enableallalerts EnableAllAlerts { get; set; }
    public Querybooleanpropertyhistory QueryBooleanPropertyHistory { get; set; }
    public Addruntimepermission AddRunTimePermission { get; set; }
    public Ismultirowtable IsMultiRowTable { get; set; }
    public Ioservice ioservice { get; set; }
    public Removeremotepropertybinding RemoveRemotePropertyBinding { get; set; }
    public Geteffectivepropertylogging GetEffectivePropertyLogging { get; set; }
    public Getprojectname GetProjectName { get; set; }
    public Getimplementedshapes GetImplementedShapes { get; set; }
    public Getthingcodepropertyvalue GetThingCodePropertyValue { get; set; }
    public Updatepropertyvalues UpdatePropertyValues { get; set; }
    public Deleteallconfigurationtablerows DeleteAllConfigurationTableRows { get; set; }
    public Addservicedefinition AddServiceDefinition { get; set; }
    public Checkdesigntimepermissionforgroup CheckDesignTimePermissionForGroup { get; set; }
    public Addorupdatealert AddOrUpdateAlert { get; set; }
    public Queryalerthistory QueryAlertHistory { get; set; }
    public Checkdesigntimepermissionforuser CheckDesignTimePermissionForUser { get; set; }
    public Getdifferencesasjson GetDifferencesAsJSON { get; set; }
    public Addpropertydefinitions AddPropertyDefinitions { get; set; }
    public Disablealertsforproperty DisableAlertsForProperty { get; set; }
    public Isenabled IsEnabled { get; set; }
    public Implementsshape ImplementsShape { get; set; }
    public Getpropertyvaluesvtq GetPropertyValuesVTQ { get; set; }
    public Setpropertylogging SetPropertyLogging { get; set; }
    public Getdifferences GetDifferences { get; set; }
    public Addlongvaluestreamentry AddLongValueStreamEntry { get; set; }
    public Addconfigurationtabledefinition AddConfigurationTableDefinition { get; set; }
    public Getnumericloggedproperties GetNumericLoggedProperties { get; set; }
    public Getnamedproperties GetNamedProperties { get; set; }
    public Geteditusername GetEditUserName { get; set; }
    public Setremotepropertybinding SetRemotePropertyBinding { get; set; }
    public Geteventdefinition GetEventDefinition { get; set; }
    public Restartthing RestartThing { get; set; }
    public Setintegeralertparameter SetIntegerAlertParameter { get; set; }
    public Addpropertydefinition AddPropertyDefinition { get; set; }
    public Getdatetimealertparameter GetDateTimeAlertParameter { get; set; }
    public Setconfigurationtable SetConfigurationTable { get; set; }
    public Isinnetwork IsInNetwork { get; set; }
    public Removedynamicsubscription RemoveDynamicSubscription { get; set; }
    public Removetags RemoveTags { get; set; }
    public Getnumberpropertyvalue GetNumberPropertyValue { get; set; }
    public Getavatar GetAvatar { get; set; }
    public Getloggedproperties GetLoggedProperties { get; set; }
    public Enablething EnableThing { get; set; }
    public Geteditdate GetEditDate { get; set; }
    public Canceledit CancelEdit { get; set; }
    public Getservicedefinition GetServiceDefinition { get; set; }
    public Getconfigurationchangehistory GetConfigurationChangeHistory { get; set; }
    public Deleteruntimepermission DeleteRunTimePermission { get; set; }
    public Getconfigurationtablerow GetConfigurationTableRow { get; set; }
    public Getstringpropertyvalue GetStringPropertyValue { get; set; }
    public Getinstancemetadataasjson GetInstanceMetadataAsJSON { get; set; }
    public Saveconfigurationtables SaveConfigurationTables { get; set; }
    public Acknowledgealert AcknowledgeAlert { get; set; }
    public Querylocationpropertyhistory QueryLocationPropertyHistory { get; set; }
    public Queryvec4propertyhistory QueryVec4PropertyHistory { get; set; }
    public Setremoteservicebinding SetRemoteServiceBinding { get; set; }
    public Deletevaluestreamentry DeleteValueStreamEntry { get; set; }
    public Isderivedfromtemplate IsDerivedFromTemplate { get; set; }
    public Writepropertiestostream WritePropertiesToStream { get; set; }
    public Getthingrelationships GetThingRelationships { get; set; }
    public Getconfigurationtables GetConfigurationTables { get; set; }
    public Addvec4valuestreamentry AddVec4ValueStreamEntry { get; set; }
    public Adddatetimevaluestreamentry AddDateTimeValueStreamEntry { get; set; }
    public Getservicedefinitions GetServiceDefinitions { get; set; }
    public Purgeselectedpropertyhistory PurgeSelectedPropertyHistory { get; set; }
    public Sethomemashup SetHomeMashup { get; set; }
    public Setowner SetOwner { get; set; }
    public Querynumberpropertyhistory QueryNumberPropertyHistory { get; set; }
    public Setnumberalertparameter SetNumberAlertParameter { get; set; }
    public Gethomemashup GetHomeMashup { get; set; }
    public Gettags GetTags { get; set; }
    public Getalertstatus GetAlertStatus { get; set; }
    public Setbooleanalertparameter SetBooleanAlertParameter { get; set; }
    public Getnetworks GetNetworks { get; set; }
    public Deleteconfigurationtable DeleteConfigurationTable { get; set; }
    public Getpermissionsforcurrentuser GetPermissionsForCurrentUser { get; set; }
    public Gettagsasinfotable GetTagsAsInfoTable { get; set; }
    public Checkdesigntimepermission CheckDesignTimePermission { get; set; }
    public Getconfigurationtabledefinition GetConfigurationTableDefinition { get; set; }
    public Querypropertyhistory QueryPropertyHistory { get; set; }
    public Getvec2propertyvalue GetVec2PropertyValue { get; set; }
    public Querylongpropertyhistory QueryLongPropertyHistory { get; set; }
    public Removelocalpropertybinding RemoveLocalPropertyBinding { get; set; }
    public Setdesigntimepermissionsasjson SetDesignTimePermissionsAsJSON { get; set; }
    public Hasoutgoingdependencies HasOutgoingDependencies { get; set; }
    public Getremoteeventbinding GetRemoteEventBinding { get; set; }
    public Getpermissionsforgroup GetPermissionsForGroup { get; set; }
    public Addintegervaluestreamentry AddIntegerValueStreamEntry { get; set; }
    public Getremotepropertybinding GetRemotePropertyBinding { get; set; }
    public Getmetadatawithpermissionsasjson GetMetadataWithPermissionsAsJSON { get; set; }
    public Settags SetTags { get; set; }
    public Getincomingdependencies GetIncomingDependencies { get; set; }
    public Getmetadata GetMetadata { get; set; }
    public Getlocallyimplementedshapes GetLocallyImplementedShapes { get; set; }
    public Requestedit RequestEdit { get; set; }
    public Promotealert PromoteAlert { get; set; }
    public Addtags AddTags { get; set; }
    public Getpermissionsforuser GetPermissionsForUser { get; set; }
    public Addbooleanvaluestreamentry AddBooleanValueStreamEntry { get; set; }
    public Getnamedpropertyvalues GetNamedPropertyValues { get; set; }
    public Checkpermissionforgroup CheckPermissionForGroup { get; set; }
    public Getdesigntimepermissionsasjson GetDesignTimePermissionsAsJSON { get; set; }
    public Setidentifier SetIdentifier { get; set; }
    public Forceedit ForceEdit { get; set; }
    public Getdatetimepropertyvalue GetDateTimePropertyValue { get; set; }
    public Disablesubscription DisableSubscription { get; set; }
    public Getanomalyalerttrainingstatisticsforalert GetAnomalyAlertTrainingStatisticsForAlert { get; set; }
    public Havepropertieschangedsince HavePropertiesChangedSince { get; set; }
    public Getidentifier GetIdentifier { get; set; }
    public Queryimagepropertyhistory QueryImagePropertyHistory { get; set; }
    public Setvisibilitypermissionsasjson SetVisibilityPermissionsAsJSON { get; set; }
    public Getalertdefinition GetAlertDefinition { get; set; }
    public Addvisibilitypermission AddVisibilityPermission { get; set; }
    public Removealert RemoveAlert { get; set; }
    public Getlocationalertparameter GetLocationAlertParameter { get; set; }
    public Getmashups GetMashups { get; set; }
    public Getruntimepermissionsasjson GetRunTimePermissionsAsJSON { get; set; }
    public Adddynamicsubscription AddDynamicSubscription { get; set; }
    public Getintegeralertparameter GetIntegerAlertParameter { get; set; }
    public Getincominglocalpropertybinding GetIncomingLocalPropertyBinding { get; set; }
    public Setvaluestream SetValueStream { get; set; }
    public Removeservicedefinition RemoveServiceDefinition { get; set; }
    public Getlongalertparameter GetLongAlertParameter { get; set; }
    public Addstringvaluestreamentry AddStringValueStreamEntry { get; set; }
    public Getpropertyvalues GetPropertyValues { get; set; }
    public Getlocalpropertybinding GetLocalPropertyBinding { get; set; }
    public Getalertsummary GetAlertSummary { get; set; }
    public Queryalertsummary QueryAlertSummary { get; set; }
    public Setlocationalertparameter SetLocationAlertParameter { get; set; }
    public Getlongpropertyvalue GetLongPropertyValue { get; set; }
    public Addpropertytransformdefinition AddPropertyTransformDefinition { get; set; }
    public Geteventdefinitions GetEventDefinitions { get; set; }
    public Getthingtemplate GetThingTemplate { get; set; }
    public Querynamedpropertyhistory QueryNamedPropertyHistory { get; set; }
    public Setpropertyvalues SetPropertyValues { get; set; }
    public Getanomalyalerttrainingstatisticsforproperty GetAnomalyAlertTrainingStatisticsForProperty { get; set; }
    public Queryintegerpropertyhistory QueryIntegerPropertyHistory { get; set; }
    public Disablething DisableThing { get; set; }
    public Getpropertydefinition GetPropertyDefinition { get; set; }
    public Addthingcodevaluestreamentry AddThingCodeValueStreamEntry { get; set; }
    public Getalertsummaryforproperty GetAlertSummaryForProperty { get; set; }
    public Getpropertytime GetPropertyTime { get; set; }
    public Addvec2valuestreamentry AddVec2ValueStreamEntry { get; set; }
    public Getincominglocalpropertybindings GetIncomingLocalPropertyBindings { get; set; }
    public Getavatarurl GetAvatarURL { get; set; }
    public Addimagevaluestreamentry AddImageValueStreamEntry { get; set; }
    public Getpropertydefinitions GetPropertyDefinitions { get; set; }
    public Getsummaryinformation GetSummaryInformation { get; set; }
    public Querythingcodepropertyhistory QueryThingCodePropertyHistory { get; set; }
    public Removeremoteeventbinding RemoveRemoteEventBinding { get; set; }
    public Getoutgoingdependenciesasnetwork GetOutgoingDependenciesAsNetwork { get; set; }
    public Getlocalalertdefinitions GetLocalAlertDefinitions { get; set; }
    public Getalertstatusesforproperty GetAlertStatusesForProperty { get; set; }
    public Getnumberalertparameter GetNumberAlertParameter { get; set; }
    public Getallanomalyalerttrainingstatistics GetAllAnomalyAlertTrainingStatistics { get; set; }
    public Getpropertyquality GetPropertyQuality { get; set; }
    public Getinstancemetadatawithpermissionsasjson GetInstanceMetadataWithPermissionsAsJSON { get; set; }
    public Getvisibilitypermissionsasjson GetVisibilityPermissionsAsJSON { get; set; }
    public Getincomingdependenciesasnetwork GetIncomingDependenciesAsNetwork { get; set; }
    public Hasalert HasAlert { get; set; }
    public Removeeventdefinition RemoveEventDefinition { get; set; }
    public Setruntimepermissionsasjson SetRunTimePermissionsAsJSON { get; set; }
    public Enablesubscription EnableSubscription { get; set; }
    public Getlastmodifieddate GetLastModifiedDate { get; set; }
    public Querydatetimepropertyhistory QueryDateTimePropertyHistory { get; set; }
    public Setremoteeventbinding SetRemoteEventBinding { get; set; }
    public Enablealertsforproperty EnableAlertsForProperty { get; set; }
    public Getstringalertparameter GetStringAlertParameter { get; set; }
    public Deleteconfigurationtablerows DeleteConfigurationTableRows { get; set; }
    public Removepropertydefinition RemovePropertyDefinition { get; set; }
    public Setconfigurationtablerows SetConfigurationTableRows { get; set; }
    public Setstringalertparameter SetStringAlertParameter { get; set; }
    public Adddesigntimepermission AddDesignTimePermission { get; set; }
    public Checkpermission CheckPermission { get; set; }
    public Setdatetimealertparameter SetDateTimeAlertParameter { get; set; }
    public Getbooleanalertparameter GetBooleanAlertParameter { get; set; }
    public Geteffectivelocalpropertybindings GetEffectiveLocalPropertyBindings { get; set; }
    public Getdescription GetDescription { get; set; }
    public Disableallalerts DisableAllAlerts { get; set; }
    public Getlocationpropertyvalue GetLocationPropertyValue { get; set; }
    public Getnamedpropertyvaluesvtq GetNamedPropertyValuesVTQ { get; set; }
    public Hasincomingdependencies HasIncomingDependencies { get; set; }
    public Getnamedpropertyvaluesvtqa GetNamedPropertyValuesVTQA { get; set; }
    public Addinfotablevaluestreamentry AddInfoTableValueStreamEntry { get; set; }
    public Getvec4propertyvalue GetVec4PropertyValue { get; set; }
    public Setavatar SetAvatar { get; set; }
    public Queryinfotablepropertyhistory QueryInfoTablePropertyHistory { get; set; }
    public Setprojectname SetProjectName { get; set; }
    public Retrainalert RetrainAlert { get; set; }
    public Getpropertylogging GetPropertyLogging { get; set; }
    public Queryvec3propertyhistory QueryVec3PropertyHistory { get; set; }
    public Setdescription SetDescription { get; set; }
    public Getconfigurationtable GetConfigurationTable { get; set; }
    public Deletedesigntimepermission DeleteDesignTimePermission { get; set; }
    public Getremoteservicebinding GetRemoteServiceBinding { get; set; }
    public Purgepropertyhistory PurgePropertyHistory { get; set; }
    public Deletevisibilitypermission DeleteVisibilityPermission { get; set; }
    public Getpropertyvaluesvtqa GetPropertyValuesVTQA { get; set; }
    public Getintegerpropertyvalue GetIntegerPropertyValue { get; set; }
    public Geteffectivelocalpropertybinding GetEffectiveLocalPropertyBinding { get; set; }
    public Getpropertyvaluesasmultirowtable GetPropertyValuesAsMultiRowTable { get; set; }
}

public class Setlocalpropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables configurationTables { get; set; }
}

public class Configurationtables
{
}

public class Getbooleanpropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables1 configurationTables { get; set; }
}

public class Configurationtables1
{
}

public class Getdesigntimepermissions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables2 configurationTables { get; set; }
}

public class Configurationtables2
{
}

public class Getvaluestream
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables3 configurationTables { get; set; }
}

public class Configurationtables3
{
}

public class Setmultirowconfigurationtable
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables4 configurationTables { get; set; }
}

public class Configurationtables4
{
}

public class Addnumbervaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables5 configurationTables { get; set; }
}

public class Configurationtables5
{
}

public class Queryvec2propertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables6 configurationTables { get; set; }
}

public class Configurationtables6
{
}

public class Addeventdefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables7 configurationTables { get; set; }
}

public class Configurationtables7
{
}

public class Getvisibilitypermissions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables8 configurationTables { get; set; }
}

public class Configurationtables8
{
}

public class Purgeallpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables9 configurationTables { get; set; }
}

public class Configurationtables9
{
}

public class Addlocationvaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables10 configurationTables { get; set; }
}

public class Configurationtables10
{
}

public class Addvec3valuestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables11 configurationTables { get; set; }
}

public class Configurationtables11
{
}

public class Getruntimepermissions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables12 configurationTables { get; set; }
}

public class Configurationtables12
{
}

public class Getvec3propertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables13 configurationTables { get; set; }
}

public class Configurationtables13
{
}

public class Getmetadataasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables14 configurationTables { get; set; }
}

public class Configurationtables14
{
}

public class Removeremoteservicebinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables15 configurationTables { get; set; }
}

public class Configurationtables15
{
}

public class Getthingsummaryinformation
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables16 configurationTables { get; set; }
}

public class Configurationtables16
{
}

public class Getalertdefinitions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables17 configurationTables { get; set; }
}

public class Configurationtables17
{
}

public class Checkpermissionforuser
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables18 configurationTables { get; set; }
}

public class Configurationtables18
{
}

public class Acknowledgeallalerts
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables19 configurationTables { get; set; }
}

public class Configurationtables19
{
}

public class Getimagepropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables20 configurationTables { get; set; }
}

public class Configurationtables20
{
}

public class Setpublished
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables21 configurationTables { get; set; }
}

public class Configurationtables21
{
}

public class Getoutgoingdependencies
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables22 configurationTables { get; set; }
}

public class Configurationtables22
{
}

public class Querystringpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables23 configurationTables { get; set; }
}

public class Configurationtables23
{
}

public class Getalertstatuses
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables24 configurationTables { get; set; }
}

public class Configurationtables24
{
}

public class Getpublished
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables25 configurationTables { get; set; }
}

public class Configurationtables25
{
}

public class Enableallalerts
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables26 configurationTables { get; set; }
}

public class Configurationtables26
{
}

public class Querybooleanpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables27 configurationTables { get; set; }
}

public class Configurationtables27
{
}

public class Addruntimepermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables28 configurationTables { get; set; }
}

public class Configurationtables28
{
}

public class Ismultirowtable
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables29 configurationTables { get; set; }
}

public class Configurationtables29
{
}

public class Ioservice
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables30 configurationTables { get; set; }
}

public class Configurationtables30
{
    public Script Script { get; set; }
}

public class Script
{
    public bool isMultiRow { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public Row[] rows { get; set; }
    public int ordinal { get; set; }
    public Datashape dataShape { get; set; }
}

public class Datashape
{
    public Fielddefinitions fieldDefinitions { get; set; }
}

public class Fielddefinitions
{
    public Code code { get; set; }
}

public class Code
{
    public string name { get; set; }
    public Aspects20 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects20
{
}

public class Row
{
    public string code { get; set; }
}

public class Removeremotepropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables31 configurationTables { get; set; }
}

public class Configurationtables31
{
}

public class Geteffectivepropertylogging
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables32 configurationTables { get; set; }
}

public class Configurationtables32
{
}

public class Getprojectname
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables33 configurationTables { get; set; }
}

public class Configurationtables33
{
}

public class Getimplementedshapes
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables34 configurationTables { get; set; }
}

public class Configurationtables34
{
}

public class Getthingcodepropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables35 configurationTables { get; set; }
}

public class Configurationtables35
{
}

public class Updatepropertyvalues
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables36 configurationTables { get; set; }
}

public class Configurationtables36
{
}

public class Deleteallconfigurationtablerows
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables37 configurationTables { get; set; }
}

public class Configurationtables37
{
}

public class Addservicedefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables38 configurationTables { get; set; }
}

public class Configurationtables38
{
}

public class Checkdesigntimepermissionforgroup
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables39 configurationTables { get; set; }
}

public class Configurationtables39
{
}

public class Addorupdatealert
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables40 configurationTables { get; set; }
}

public class Configurationtables40
{
}

public class Queryalerthistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables41 configurationTables { get; set; }
}

public class Configurationtables41
{
}

public class Checkdesigntimepermissionforuser
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables42 configurationTables { get; set; }
}

public class Configurationtables42
{
}

public class Getdifferencesasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables43 configurationTables { get; set; }
}

public class Configurationtables43
{
}

public class Addpropertydefinitions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables44 configurationTables { get; set; }
}

public class Configurationtables44
{
}

public class Disablealertsforproperty
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables45 configurationTables { get; set; }
}

public class Configurationtables45
{
}

public class Isenabled
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables46 configurationTables { get; set; }
}

public class Configurationtables46
{
}

public class Implementsshape
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables47 configurationTables { get; set; }
}

public class Configurationtables47
{
}

public class Getpropertyvaluesvtq
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables48 configurationTables { get; set; }
}

public class Configurationtables48
{
}

public class Setpropertylogging
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables49 configurationTables { get; set; }
}

public class Configurationtables49
{
}

public class Getdifferences
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables50 configurationTables { get; set; }
}

public class Configurationtables50
{
}

public class Addlongvaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables51 configurationTables { get; set; }
}

public class Configurationtables51
{
}

public class Addconfigurationtabledefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables52 configurationTables { get; set; }
}

public class Configurationtables52
{
}

public class Getnumericloggedproperties
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables53 configurationTables { get; set; }
}

public class Configurationtables53
{
}

public class Getnamedproperties
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables54 configurationTables { get; set; }
}

public class Configurationtables54
{
}

public class Geteditusername
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables55 configurationTables { get; set; }
}

public class Configurationtables55
{
}

public class Setremotepropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables56 configurationTables { get; set; }
}

public class Configurationtables56
{
}

public class Geteventdefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables57 configurationTables { get; set; }
}

public class Configurationtables57
{
}

public class Restartthing
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables58 configurationTables { get; set; }
}

public class Configurationtables58
{
}

public class Setintegeralertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables59 configurationTables { get; set; }
}

public class Configurationtables59
{
}

public class Addpropertydefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables60 configurationTables { get; set; }
}

public class Configurationtables60
{
}

public class Getdatetimealertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables61 configurationTables { get; set; }
}

public class Configurationtables61
{
}

public class Setconfigurationtable
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables62 configurationTables { get; set; }
}

public class Configurationtables62
{
}

public class Isinnetwork
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables63 configurationTables { get; set; }
}

public class Configurationtables63
{
}

public class Removedynamicsubscription
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables64 configurationTables { get; set; }
}

public class Configurationtables64
{
}

public class Removetags
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables65 configurationTables { get; set; }
}

public class Configurationtables65
{
}

public class Getnumberpropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables66 configurationTables { get; set; }
}

public class Configurationtables66
{
}

public class Getavatar
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables67 configurationTables { get; set; }
}

public class Configurationtables67
{
}

public class Getloggedproperties
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables68 configurationTables { get; set; }
}

public class Configurationtables68
{
}

public class Enablething
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables69 configurationTables { get; set; }
}

public class Configurationtables69
{
}

public class Geteditdate
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables70 configurationTables { get; set; }
}

public class Configurationtables70
{
}

public class Canceledit
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables71 configurationTables { get; set; }
}

public class Configurationtables71
{
}

public class Getservicedefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables72 configurationTables { get; set; }
}

public class Configurationtables72
{
}

public class Getconfigurationchangehistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables73 configurationTables { get; set; }
}

public class Configurationtables73
{
}

public class Deleteruntimepermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables74 configurationTables { get; set; }
}

public class Configurationtables74
{
}

public class Getconfigurationtablerow
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables75 configurationTables { get; set; }
}

public class Configurationtables75
{
}

public class Getstringpropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables76 configurationTables { get; set; }
}

public class Configurationtables76
{
}

public class Getinstancemetadataasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables77 configurationTables { get; set; }
}

public class Configurationtables77
{
}

public class Saveconfigurationtables
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables78 configurationTables { get; set; }
}

public class Configurationtables78
{
}

public class Acknowledgealert
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables79 configurationTables { get; set; }
}

public class Configurationtables79
{
}

public class Querylocationpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables80 configurationTables { get; set; }
}

public class Configurationtables80
{
}

public class Queryvec4propertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables81 configurationTables { get; set; }
}

public class Configurationtables81
{
}

public class Setremoteservicebinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables82 configurationTables { get; set; }
}

public class Configurationtables82
{
}

public class Deletevaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables83 configurationTables { get; set; }
}

public class Configurationtables83
{
}

public class Isderivedfromtemplate
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables84 configurationTables { get; set; }
}

public class Configurationtables84
{
}

public class Writepropertiestostream
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables85 configurationTables { get; set; }
}

public class Configurationtables85
{
}

public class Getthingrelationships
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables86 configurationTables { get; set; }
}

public class Configurationtables86
{
}

public class Getconfigurationtables
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables87 configurationTables { get; set; }
}

public class Configurationtables87
{
}

public class Addvec4valuestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables88 configurationTables { get; set; }
}

public class Configurationtables88
{
}

public class Adddatetimevaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables89 configurationTables { get; set; }
}

public class Configurationtables89
{
}

public class Getservicedefinitions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables90 configurationTables { get; set; }
}

public class Configurationtables90
{
}

public class Purgeselectedpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables91 configurationTables { get; set; }
}

public class Configurationtables91
{
}

public class Sethomemashup
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables92 configurationTables { get; set; }
}

public class Configurationtables92
{
}

public class Setowner
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables93 configurationTables { get; set; }
}

public class Configurationtables93
{
}

public class Querynumberpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables94 configurationTables { get; set; }
}

public class Configurationtables94
{
}

public class Setnumberalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables95 configurationTables { get; set; }
}

public class Configurationtables95
{
}

public class Gethomemashup
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables96 configurationTables { get; set; }
}

public class Configurationtables96
{
}

public class Gettags
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables97 configurationTables { get; set; }
}

public class Configurationtables97
{
}

public class Getalertstatus
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables98 configurationTables { get; set; }
}

public class Configurationtables98
{
}

public class Setbooleanalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables99 configurationTables { get; set; }
}

public class Configurationtables99
{
}

public class Getnetworks
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables100 configurationTables { get; set; }
}

public class Configurationtables100
{
}

public class Deleteconfigurationtable
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables101 configurationTables { get; set; }
}

public class Configurationtables101
{
}

public class Getpermissionsforcurrentuser
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables102 configurationTables { get; set; }
}

public class Configurationtables102
{
}

public class Gettagsasinfotable
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables103 configurationTables { get; set; }
}

public class Configurationtables103
{
}

public class Checkdesigntimepermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables104 configurationTables { get; set; }
}

public class Configurationtables104
{
}

public class Getconfigurationtabledefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables105 configurationTables { get; set; }
}

public class Configurationtables105
{
}

public class Querypropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables106 configurationTables { get; set; }
}

public class Configurationtables106
{
}

public class Getvec2propertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables107 configurationTables { get; set; }
}

public class Configurationtables107
{
}

public class Querylongpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables108 configurationTables { get; set; }
}

public class Configurationtables108
{
}

public class Removelocalpropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables109 configurationTables { get; set; }
}

public class Configurationtables109
{
}

public class Setdesigntimepermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables110 configurationTables { get; set; }
}

public class Configurationtables110
{
}

public class Hasoutgoingdependencies
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables111 configurationTables { get; set; }
}

public class Configurationtables111
{
}

public class Getremoteeventbinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables112 configurationTables { get; set; }
}

public class Configurationtables112
{
}

public class Getpermissionsforgroup
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables113 configurationTables { get; set; }
}

public class Configurationtables113
{
}

public class Addintegervaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables114 configurationTables { get; set; }
}

public class Configurationtables114
{
}

public class Getremotepropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables115 configurationTables { get; set; }
}

public class Configurationtables115
{
}

public class Getmetadatawithpermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables116 configurationTables { get; set; }
}

public class Configurationtables116
{
}

public class Settags
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables117 configurationTables { get; set; }
}

public class Configurationtables117
{
}

public class Getincomingdependencies
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables118 configurationTables { get; set; }
}

public class Configurationtables118
{
}

public class Getmetadata
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables119 configurationTables { get; set; }
}

public class Configurationtables119
{
}

public class Getlocallyimplementedshapes
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables120 configurationTables { get; set; }
}

public class Configurationtables120
{
}

public class Requestedit
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables121 configurationTables { get; set; }
}

public class Configurationtables121
{
}

public class Promotealert
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables122 configurationTables { get; set; }
}

public class Configurationtables122
{
}

public class Addtags
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables123 configurationTables { get; set; }
}

public class Configurationtables123
{
}

public class Getpermissionsforuser
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables124 configurationTables { get; set; }
}

public class Configurationtables124
{
}

public class Addbooleanvaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables125 configurationTables { get; set; }
}

public class Configurationtables125
{
}

public class Getnamedpropertyvalues
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables126 configurationTables { get; set; }
}

public class Configurationtables126
{
}

public class Checkpermissionforgroup
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables127 configurationTables { get; set; }
}

public class Configurationtables127
{
}

public class Getdesigntimepermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables128 configurationTables { get; set; }
}

public class Configurationtables128
{
}

public class Setidentifier
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables129 configurationTables { get; set; }
}

public class Configurationtables129
{
}

public class Forceedit
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables130 configurationTables { get; set; }
}

public class Configurationtables130
{
}

public class Getdatetimepropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables131 configurationTables { get; set; }
}

public class Configurationtables131
{
}

public class Disablesubscription
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables132 configurationTables { get; set; }
}

public class Configurationtables132
{
}

public class Getanomalyalerttrainingstatisticsforalert
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables133 configurationTables { get; set; }
}

public class Configurationtables133
{
}

public class Havepropertieschangedsince
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables134 configurationTables { get; set; }
}

public class Configurationtables134
{
}

public class Getidentifier
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables135 configurationTables { get; set; }
}

public class Configurationtables135
{
}

public class Queryimagepropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables136 configurationTables { get; set; }
}

public class Configurationtables136
{
}

public class Setvisibilitypermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables137 configurationTables { get; set; }
}

public class Configurationtables137
{
}

public class Getalertdefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables138 configurationTables { get; set; }
}

public class Configurationtables138
{
}

public class Addvisibilitypermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables139 configurationTables { get; set; }
}

public class Configurationtables139
{
}

public class Removealert
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables140 configurationTables { get; set; }
}

public class Configurationtables140
{
}

public class Getlocationalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables141 configurationTables { get; set; }
}

public class Configurationtables141
{
}

public class Getmashups
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables142 configurationTables { get; set; }
}

public class Configurationtables142
{
}

public class Getruntimepermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables143 configurationTables { get; set; }
}

public class Configurationtables143
{
}

public class Adddynamicsubscription
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables144 configurationTables { get; set; }
}

public class Configurationtables144
{
}

public class Getintegeralertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables145 configurationTables { get; set; }
}

public class Configurationtables145
{
}

public class Getincominglocalpropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables146 configurationTables { get; set; }
}

public class Configurationtables146
{
}

public class Setvaluestream
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables147 configurationTables { get; set; }
}

public class Configurationtables147
{
}

public class Removeservicedefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables148 configurationTables { get; set; }
}

public class Configurationtables148
{
}

public class Getlongalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables149 configurationTables { get; set; }
}

public class Configurationtables149
{
}

public class Addstringvaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables150 configurationTables { get; set; }
}

public class Configurationtables150
{
}

public class Getpropertyvalues
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables151 configurationTables { get; set; }
}

public class Configurationtables151
{
}

public class Getlocalpropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables152 configurationTables { get; set; }
}

public class Configurationtables152
{
}

public class Getalertsummary
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables153 configurationTables { get; set; }
}

public class Configurationtables153
{
}

public class Queryalertsummary
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables154 configurationTables { get; set; }
}

public class Configurationtables154
{
}

public class Setlocationalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables155 configurationTables { get; set; }
}

public class Configurationtables155
{
}

public class Getlongpropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables156 configurationTables { get; set; }
}

public class Configurationtables156
{
}

public class Addpropertytransformdefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables157 configurationTables { get; set; }
}

public class Configurationtables157
{
}

public class Geteventdefinitions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables158 configurationTables { get; set; }
}

public class Configurationtables158
{
}

public class Getthingtemplate
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables159 configurationTables { get; set; }
}

public class Configurationtables159
{
}

public class Querynamedpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables160 configurationTables { get; set; }
}

public class Configurationtables160
{
}

public class Setpropertyvalues
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables161 configurationTables { get; set; }
}

public class Configurationtables161
{
}

public class Getanomalyalerttrainingstatisticsforproperty
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables162 configurationTables { get; set; }
}

public class Configurationtables162
{
}

public class Queryintegerpropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables163 configurationTables { get; set; }
}

public class Configurationtables163
{
}

public class Disablething
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables164 configurationTables { get; set; }
}

public class Configurationtables164
{
}

public class Getpropertydefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables165 configurationTables { get; set; }
}

public class Configurationtables165
{
}

public class Addthingcodevaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables166 configurationTables { get; set; }
}

public class Configurationtables166
{
}

public class Getalertsummaryforproperty
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables167 configurationTables { get; set; }
}

public class Configurationtables167
{
}

public class Getpropertytime
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables168 configurationTables { get; set; }
}

public class Configurationtables168
{
}

public class Addvec2valuestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables169 configurationTables { get; set; }
}

public class Configurationtables169
{
}

public class Getincominglocalpropertybindings
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables170 configurationTables { get; set; }
}

public class Configurationtables170
{
}

public class Getavatarurl
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables171 configurationTables { get; set; }
}

public class Configurationtables171
{
}

public class Addimagevaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables172 configurationTables { get; set; }
}

public class Configurationtables172
{
}

public class Getpropertydefinitions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables173 configurationTables { get; set; }
}

public class Configurationtables173
{
}

public class Getsummaryinformation
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables174 configurationTables { get; set; }
}

public class Configurationtables174
{
}

public class Querythingcodepropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables175 configurationTables { get; set; }
}

public class Configurationtables175
{
}

public class Removeremoteeventbinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables176 configurationTables { get; set; }
}

public class Configurationtables176
{
}

public class Getoutgoingdependenciesasnetwork
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables177 configurationTables { get; set; }
}

public class Configurationtables177
{
}

public class Getlocalalertdefinitions
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables178 configurationTables { get; set; }
}

public class Configurationtables178
{
}

public class Getalertstatusesforproperty
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables179 configurationTables { get; set; }
}

public class Configurationtables179
{
}

public class Getnumberalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables180 configurationTables { get; set; }
}

public class Configurationtables180
{
}

public class Getallanomalyalerttrainingstatistics
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables181 configurationTables { get; set; }
}

public class Configurationtables181
{
}

public class Getpropertyquality
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables182 configurationTables { get; set; }
}

public class Configurationtables182
{
}

public class Getinstancemetadatawithpermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables183 configurationTables { get; set; }
}

public class Configurationtables183
{
}

public class Getvisibilitypermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables184 configurationTables { get; set; }
}

public class Configurationtables184
{
}

public class Getincomingdependenciesasnetwork
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables185 configurationTables { get; set; }
}

public class Configurationtables185
{
}

public class Hasalert
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables186 configurationTables { get; set; }
}

public class Configurationtables186
{
}

public class Removeeventdefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables187 configurationTables { get; set; }
}

public class Configurationtables187
{
}

public class Setruntimepermissionsasjson
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables188 configurationTables { get; set; }
}

public class Configurationtables188
{
}

public class Enablesubscription
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables189 configurationTables { get; set; }
}

public class Configurationtables189
{
}

public class Getlastmodifieddate
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables190 configurationTables { get; set; }
}

public class Configurationtables190
{
}

public class Querydatetimepropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables191 configurationTables { get; set; }
}

public class Configurationtables191
{
}

public class Setremoteeventbinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables192 configurationTables { get; set; }
}

public class Configurationtables192
{
}

public class Enablealertsforproperty
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables193 configurationTables { get; set; }
}

public class Configurationtables193
{
}

public class Getstringalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables194 configurationTables { get; set; }
}

public class Configurationtables194
{
}

public class Deleteconfigurationtablerows
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables195 configurationTables { get; set; }
}

public class Configurationtables195
{
}

public class Removepropertydefinition
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables196 configurationTables { get; set; }
}

public class Configurationtables196
{
}

public class Setconfigurationtablerows
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables197 configurationTables { get; set; }
}

public class Configurationtables197
{
}

public class Setstringalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables198 configurationTables { get; set; }
}

public class Configurationtables198
{
}

public class Adddesigntimepermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables199 configurationTables { get; set; }
}

public class Configurationtables199
{
}

public class Checkpermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables200 configurationTables { get; set; }
}

public class Configurationtables200
{
}

public class Setdatetimealertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables201 configurationTables { get; set; }
}

public class Configurationtables201
{
}

public class Getbooleanalertparameter
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables202 configurationTables { get; set; }
}

public class Configurationtables202
{
}

public class Geteffectivelocalpropertybindings
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables203 configurationTables { get; set; }
}

public class Configurationtables203
{
}

public class Getdescription
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables204 configurationTables { get; set; }
}

public class Configurationtables204
{
}

public class Disableallalerts
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables205 configurationTables { get; set; }
}

public class Configurationtables205
{
}

public class Getlocationpropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables206 configurationTables { get; set; }
}

public class Configurationtables206
{
}

public class Getnamedpropertyvaluesvtq
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables207 configurationTables { get; set; }
}

public class Configurationtables207
{
}

public class Hasincomingdependencies
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables208 configurationTables { get; set; }
}

public class Configurationtables208
{
}

public class Getnamedpropertyvaluesvtqa
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables209 configurationTables { get; set; }
}

public class Configurationtables209
{
}

public class Addinfotablevaluestreamentry
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables210 configurationTables { get; set; }
}

public class Configurationtables210
{
}

public class Getvec4propertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables211 configurationTables { get; set; }
}

public class Configurationtables211
{
}

public class Setavatar
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables212 configurationTables { get; set; }
}

public class Configurationtables212
{
}

public class Queryinfotablepropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables213 configurationTables { get; set; }
}

public class Configurationtables213
{
}

public class Setprojectname
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables214 configurationTables { get; set; }
}

public class Configurationtables214
{
}

public class Retrainalert
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables215 configurationTables { get; set; }
}

public class Configurationtables215
{
}

public class Getpropertylogging
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables216 configurationTables { get; set; }
}

public class Configurationtables216
{
}

public class Queryvec3propertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables217 configurationTables { get; set; }
}

public class Configurationtables217
{
}

public class Setdescription
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables218 configurationTables { get; set; }
}

public class Configurationtables218
{
}

public class Getconfigurationtable
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables219 configurationTables { get; set; }
}

public class Configurationtables219
{
}

public class Deletedesigntimepermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables220 configurationTables { get; set; }
}

public class Configurationtables220
{
}

public class Getremoteservicebinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables221 configurationTables { get; set; }
}

public class Configurationtables221
{
}

public class Purgepropertyhistory
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables222 configurationTables { get; set; }
}

public class Configurationtables222
{
}

public class Deletevisibilitypermission
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables223 configurationTables { get; set; }
}

public class Configurationtables223
{
}

public class Getpropertyvaluesvtqa
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables224 configurationTables { get; set; }
}

public class Configurationtables224
{
}

public class Getintegerpropertyvalue
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables225 configurationTables { get; set; }
}

public class Configurationtables225
{
}

public class Geteffectivelocalpropertybinding
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables226 configurationTables { get; set; }
}

public class Configurationtables226
{
}

public class Getpropertyvaluesasmultirowtable
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables227 configurationTables { get; set; }
}

public class Configurationtables227
{
}

public class Servicemappings
{
    public Configurationchanges ConfigurationChanges { get; set; }
    public Incomingdependencies IncomingDependencies { get; set; }
    public Outgoingdependencynetwork OutgoingDependencyNetwork { get; set; }
    public Outgoingdependencies OutgoingDependencies { get; set; }
    public Incomingdependencynetwork IncomingDependencyNetwork { get; set; }
    public Propertyhistory PropertyHistory { get; set; }
}

public class Configurationchanges
{
    public string queryService { get; set; }
    public string deleteService { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string listService { get; set; }
}

public class Incomingdependencies
{
    public string queryService { get; set; }
    public string deleteService { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string listService { get; set; }
}

public class Outgoingdependencynetwork
{
    public string queryService { get; set; }
    public string deleteService { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string listService { get; set; }
}

public class Outgoingdependencies
{
    public string queryService { get; set; }
    public string deleteService { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string listService { get; set; }
}

public class Incomingdependencynetwork
{
    public string queryService { get; set; }
    public string deleteService { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string listService { get; set; }
}

public class Propertyhistory
{
    public string queryService { get; set; }
    public string deleteService { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string listService { get; set; }
}

public class Servicedefinitions
{
    public Setlocalpropertybinding1 SetLocalPropertyBinding { get; set; }
    public Getbooleanpropertyvalue1 GetBooleanPropertyValue { get; set; }
    public Getdesigntimepermissions1 GetDesignTimePermissions { get; set; }
    public Getvaluestream1 GetValueStream { get; set; }
    public Setmultirowconfigurationtable1 SetMultiRowConfigurationTable { get; set; }
    public Addnumbervaluestreamentry1 AddNumberValueStreamEntry { get; set; }
    public Queryvec2propertyhistory1 QueryVec2PropertyHistory { get; set; }
    public Addeventdefinition1 AddEventDefinition { get; set; }
    public Getvisibilitypermissions1 GetVisibilityPermissions { get; set; }
    public Purgeallpropertyhistory1 PurgeAllPropertyHistory { get; set; }
    public Addlocationvaluestreamentry1 AddLocationValueStreamEntry { get; set; }
    public Addvec3valuestreamentry1 AddVec3ValueStreamEntry { get; set; }
    public Getruntimepermissions1 GetRunTimePermissions { get; set; }
    public Getvec3propertyvalue1 GetVec3PropertyValue { get; set; }
    public Getmetadataasjson1 GetMetadataAsJSON { get; set; }
    public Removeremoteservicebinding1 RemoveRemoteServiceBinding { get; set; }
    public Getthingsummaryinformation1 GetThingSummaryInformation { get; set; }
    public Getalertdefinitions1 GetAlertDefinitions { get; set; }
    public Checkpermissionforuser1 CheckPermissionForUser { get; set; }
    public Acknowledgeallalerts1 AcknowledgeAllAlerts { get; set; }
    public Getimagepropertyvalue1 GetImagePropertyValue { get; set; }
    public Setpublished1 SetPublished { get; set; }
    public Getoutgoingdependencies1 GetOutgoingDependencies { get; set; }
    public Querystringpropertyhistory1 QueryStringPropertyHistory { get; set; }
    public Getalertstatuses1 GetAlertStatuses { get; set; }
    public Getpublished1 GetPublished { get; set; }
    public Enableallalerts1 EnableAllAlerts { get; set; }
    public Querybooleanpropertyhistory1 QueryBooleanPropertyHistory { get; set; }
    public Addruntimepermission1 AddRunTimePermission { get; set; }
    public Ismultirowtable1 IsMultiRowTable { get; set; }
    public Ioservice1 ioservice { get; set; }
    public Removeremotepropertybinding1 RemoveRemotePropertyBinding { get; set; }
    public Geteffectivepropertylogging1 GetEffectivePropertyLogging { get; set; }
    public Getprojectname1 GetProjectName { get; set; }
    public Getimplementedshapes1 GetImplementedShapes { get; set; }
    public Getthingcodepropertyvalue1 GetThingCodePropertyValue { get; set; }
    public Updatepropertyvalues1 UpdatePropertyValues { get; set; }
    public Deleteallconfigurationtablerows1 DeleteAllConfigurationTableRows { get; set; }
    public Addservicedefinition1 AddServiceDefinition { get; set; }
    public Checkdesigntimepermissionforgroup1 CheckDesignTimePermissionForGroup { get; set; }
    public Addorupdatealert1 AddOrUpdateAlert { get; set; }
    public Queryalerthistory1 QueryAlertHistory { get; set; }
    public Checkdesigntimepermissionforuser1 CheckDesignTimePermissionForUser { get; set; }
    public Getdifferencesasjson1 GetDifferencesAsJSON { get; set; }
    public Addpropertydefinitions1 AddPropertyDefinitions { get; set; }
    public Disablealertsforproperty1 DisableAlertsForProperty { get; set; }
    public Isenabled1 IsEnabled { get; set; }
    public Implementsshape1 ImplementsShape { get; set; }
    public Getpropertyvaluesvtq1 GetPropertyValuesVTQ { get; set; }
    public Setpropertylogging1 SetPropertyLogging { get; set; }
    public Getdifferences1 GetDifferences { get; set; }
    public Addlongvaluestreamentry1 AddLongValueStreamEntry { get; set; }
    public Addconfigurationtabledefinition1 AddConfigurationTableDefinition { get; set; }
    public Getnumericloggedproperties1 GetNumericLoggedProperties { get; set; }
    public Getnamedproperties1 GetNamedProperties { get; set; }
    public Setremotepropertybinding1 SetRemotePropertyBinding { get; set; }
    public Geteventdefinition1 GetEventDefinition { get; set; }
    public Restartthing1 RestartThing { get; set; }
    public Setintegeralertparameter1 SetIntegerAlertParameter { get; set; }
    public Addpropertydefinition1 AddPropertyDefinition { get; set; }
    public Getdatetimealertparameter1 GetDateTimeAlertParameter { get; set; }
    public Setconfigurationtable1 SetConfigurationTable { get; set; }
    public Isinnetwork1 IsInNetwork { get; set; }
    public Removedynamicsubscription1 RemoveDynamicSubscription { get; set; }
    public Removetags1 RemoveTags { get; set; }
    public Getnumberpropertyvalue1 GetNumberPropertyValue { get; set; }
    public Getavatar1 GetAvatar { get; set; }
    public Getloggedproperties1 GetLoggedProperties { get; set; }
    public Enablething1 EnableThing { get; set; }
    public Getservicedefinition1 GetServiceDefinition { get; set; }
    public Getconfigurationchangehistory1 GetConfigurationChangeHistory { get; set; }
    public Deleteruntimepermission1 DeleteRunTimePermission { get; set; }
    public Getconfigurationtablerow1 GetConfigurationTableRow { get; set; }
    public Getstringpropertyvalue1 GetStringPropertyValue { get; set; }
    public Getinstancemetadataasjson1 GetInstanceMetadataAsJSON { get; set; }
    public Saveconfigurationtables1 SaveConfigurationTables { get; set; }
    public Acknowledgealert1 AcknowledgeAlert { get; set; }
    public Querylocationpropertyhistory1 QueryLocationPropertyHistory { get; set; }
    public Queryvec4propertyhistory1 QueryVec4PropertyHistory { get; set; }
    public Setremoteservicebinding1 SetRemoteServiceBinding { get; set; }
    public Isderivedfromtemplate1 IsDerivedFromTemplate { get; set; }
    public Writepropertiestostream1 WritePropertiesToStream { get; set; }
    public Getthingrelationships1 GetThingRelationships { get; set; }
    public Getconfigurationtables1 GetConfigurationTables { get; set; }
    public Addvec4valuestreamentry1 AddVec4ValueStreamEntry { get; set; }
    public Adddatetimevaluestreamentry1 AddDateTimeValueStreamEntry { get; set; }
    public Getservicedefinitions1 GetServiceDefinitions { get; set; }
    public Purgeselectedpropertyhistory1 PurgeSelectedPropertyHistory { get; set; }
    public Sethomemashup1 SetHomeMashup { get; set; }
    public Setowner1 SetOwner { get; set; }
    public Querynumberpropertyhistory1 QueryNumberPropertyHistory { get; set; }
    public Setnumberalertparameter1 SetNumberAlertParameter { get; set; }
    public Gethomemashup1 GetHomeMashup { get; set; }
    public Gettags1 GetTags { get; set; }
    public Getalertstatus1 GetAlertStatus { get; set; }
    public Setbooleanalertparameter1 SetBooleanAlertParameter { get; set; }
    public Getnetworks1 GetNetworks { get; set; }
    public Deleteconfigurationtable1 DeleteConfigurationTable { get; set; }
    public Getpermissionsforcurrentuser1 GetPermissionsForCurrentUser { get; set; }
    public Gettagsasinfotable1 GetTagsAsInfoTable { get; set; }
    public Checkdesigntimepermission1 CheckDesignTimePermission { get; set; }
    public Getconfigurationtabledefinition1 GetConfigurationTableDefinition { get; set; }
    public Querypropertyhistory1 QueryPropertyHistory { get; set; }
    public Getvec2propertyvalue1 GetVec2PropertyValue { get; set; }
    public Querylongpropertyhistory1 QueryLongPropertyHistory { get; set; }
    public Removelocalpropertybinding1 RemoveLocalPropertyBinding { get; set; }
    public Setdesigntimepermissionsasjson1 SetDesignTimePermissionsAsJSON { get; set; }
    public Hasoutgoingdependencies1 HasOutgoingDependencies { get; set; }
    public Getremoteeventbinding1 GetRemoteEventBinding { get; set; }
    public Getpermissionsforgroup1 GetPermissionsForGroup { get; set; }
    public Addintegervaluestreamentry1 AddIntegerValueStreamEntry { get; set; }
    public Getremotepropertybinding1 GetRemotePropertyBinding { get; set; }
    public Getmetadatawithpermissionsasjson1 GetMetadataWithPermissionsAsJSON { get; set; }
    public Settags1 SetTags { get; set; }
    public Getincomingdependencies1 GetIncomingDependencies { get; set; }
    public Getmetadata1 GetMetadata { get; set; }
    public Getlocallyimplementedshapes1 GetLocallyImplementedShapes { get; set; }
    public Promotealert1 PromoteAlert { get; set; }
    public Addtags1 AddTags { get; set; }
    public Getpermissionsforuser1 GetPermissionsForUser { get; set; }
    public Addbooleanvaluestreamentry1 AddBooleanValueStreamEntry { get; set; }
    public Getnamedpropertyvalues1 GetNamedPropertyValues { get; set; }
    public Checkpermissionforgroup1 CheckPermissionForGroup { get; set; }
    public Getdesigntimepermissionsasjson1 GetDesignTimePermissionsAsJSON { get; set; }
    public Setidentifier1 SetIdentifier { get; set; }
    public Getdatetimepropertyvalue1 GetDateTimePropertyValue { get; set; }
    public Disablesubscription1 DisableSubscription { get; set; }
    public Getanomalyalerttrainingstatisticsforalert1 GetAnomalyAlertTrainingStatisticsForAlert { get; set; }
    public Havepropertieschangedsince1 HavePropertiesChangedSince { get; set; }
    public Getidentifier1 GetIdentifier { get; set; }
    public Queryimagepropertyhistory1 QueryImagePropertyHistory { get; set; }
    public Setvisibilitypermissionsasjson1 SetVisibilityPermissionsAsJSON { get; set; }
    public Getalertdefinition1 GetAlertDefinition { get; set; }
    public Addvisibilitypermission1 AddVisibilityPermission { get; set; }
    public Removealert1 RemoveAlert { get; set; }
    public Getlocationalertparameter1 GetLocationAlertParameter { get; set; }
    public Getmashups1 GetMashups { get; set; }
    public Getruntimepermissionsasjson1 GetRunTimePermissionsAsJSON { get; set; }
    public Adddynamicsubscription1 AddDynamicSubscription { get; set; }
    public Getintegeralertparameter1 GetIntegerAlertParameter { get; set; }
    public Getincominglocalpropertybinding1 GetIncomingLocalPropertyBinding { get; set; }
    public Setvaluestream1 SetValueStream { get; set; }
    public Removeservicedefinition1 RemoveServiceDefinition { get; set; }
    public Getlongalertparameter1 GetLongAlertParameter { get; set; }
    public Addstringvaluestreamentry1 AddStringValueStreamEntry { get; set; }
    public Getpropertyvalues1 GetPropertyValues { get; set; }
    public Getlocalpropertybinding1 GetLocalPropertyBinding { get; set; }
    public Getalertsummary1 GetAlertSummary { get; set; }
    public Queryalertsummary1 QueryAlertSummary { get; set; }
    public Setlocationalertparameter1 SetLocationAlertParameter { get; set; }
    public Getlongpropertyvalue1 GetLongPropertyValue { get; set; }
    public Addpropertytransformdefinition1 AddPropertyTransformDefinition { get; set; }
    public Geteventdefinitions1 GetEventDefinitions { get; set; }
    public Getthingtemplate1 GetThingTemplate { get; set; }
    public Querynamedpropertyhistory1 QueryNamedPropertyHistory { get; set; }
    public Setpropertyvalues1 SetPropertyValues { get; set; }
    public Getanomalyalerttrainingstatisticsforproperty1 GetAnomalyAlertTrainingStatisticsForProperty { get; set; }
    public Queryintegerpropertyhistory1 QueryIntegerPropertyHistory { get; set; }
    public Disablething1 DisableThing { get; set; }
    public Getpropertydefinition1 GetPropertyDefinition { get; set; }
    public Addthingcodevaluestreamentry1 AddThingCodeValueStreamEntry { get; set; }
    public Getalertsummaryforproperty1 GetAlertSummaryForProperty { get; set; }
    public Getpropertytime1 GetPropertyTime { get; set; }
    public Addvec2valuestreamentry1 AddVec2ValueStreamEntry { get; set; }
    public Getincominglocalpropertybindings1 GetIncomingLocalPropertyBindings { get; set; }
    public Getavatarurl1 GetAvatarURL { get; set; }
    public Addimagevaluestreamentry1 AddImageValueStreamEntry { get; set; }
    public Getpropertydefinitions1 GetPropertyDefinitions { get; set; }
    public Getsummaryinformation1 GetSummaryInformation { get; set; }
    public Querythingcodepropertyhistory1 QueryThingCodePropertyHistory { get; set; }
    public Removeremoteeventbinding1 RemoveRemoteEventBinding { get; set; }
    public Getoutgoingdependenciesasnetwork1 GetOutgoingDependenciesAsNetwork { get; set; }
    public Getlocalalertdefinitions1 GetLocalAlertDefinitions { get; set; }
    public Getalertstatusesforproperty1 GetAlertStatusesForProperty { get; set; }
    public Getnumberalertparameter1 GetNumberAlertParameter { get; set; }
    public Getallanomalyalerttrainingstatistics1 GetAllAnomalyAlertTrainingStatistics { get; set; }
    public Getpropertyquality1 GetPropertyQuality { get; set; }
    public Getinstancemetadatawithpermissionsasjson1 GetInstanceMetadataWithPermissionsAsJSON { get; set; }
    public Getvisibilitypermissionsasjson1 GetVisibilityPermissionsAsJSON { get; set; }
    public Getincomingdependenciesasnetwork1 GetIncomingDependenciesAsNetwork { get; set; }
    public Hasalert1 HasAlert { get; set; }
    public Removeeventdefinition1 RemoveEventDefinition { get; set; }
    public Setruntimepermissionsasjson1 SetRunTimePermissionsAsJSON { get; set; }
    public Enablesubscription1 EnableSubscription { get; set; }
    public Getlastmodifieddate1 GetLastModifiedDate { get; set; }
    public Querydatetimepropertyhistory1 QueryDateTimePropertyHistory { get; set; }
    public Setremoteeventbinding1 SetRemoteEventBinding { get; set; }
    public Enablealertsforproperty1 EnableAlertsForProperty { get; set; }
    public Getstringalertparameter1 GetStringAlertParameter { get; set; }
    public Deleteconfigurationtablerows1 DeleteConfigurationTableRows { get; set; }
    public Removepropertydefinition1 RemovePropertyDefinition { get; set; }
    public Setconfigurationtablerows1 SetConfigurationTableRows { get; set; }
    public Setstringalertparameter1 SetStringAlertParameter { get; set; }
    public Adddesigntimepermission1 AddDesignTimePermission { get; set; }
    public Checkpermission1 CheckPermission { get; set; }
    public Setdatetimealertparameter1 SetDateTimeAlertParameter { get; set; }
    public Getbooleanalertparameter1 GetBooleanAlertParameter { get; set; }
    public Geteffectivelocalpropertybindings1 GetEffectiveLocalPropertyBindings { get; set; }
    public Getdescription1 GetDescription { get; set; }
    public Disableallalerts1 DisableAllAlerts { get; set; }
    public Getlocationpropertyvalue1 GetLocationPropertyValue { get; set; }
    public Getnamedpropertyvaluesvtq1 GetNamedPropertyValuesVTQ { get; set; }
    public Hasincomingdependencies1 HasIncomingDependencies { get; set; }
    public Getnamedpropertyvaluesvtqa1 GetNamedPropertyValuesVTQA { get; set; }
    public Addinfotablevaluestreamentry1 AddInfoTableValueStreamEntry { get; set; }
    public Getvec4propertyvalue1 GetVec4PropertyValue { get; set; }
    public Setavatar1 SetAvatar { get; set; }
    public Queryinfotablepropertyhistory1 QueryInfoTablePropertyHistory { get; set; }
    public Setprojectname1 SetProjectName { get; set; }
    public Retrainalert1 RetrainAlert { get; set; }
    public Getpropertylogging1 GetPropertyLogging { get; set; }
    public Queryvec3propertyhistory1 QueryVec3PropertyHistory { get; set; }
    public Setdescription1 SetDescription { get; set; }
    public Getconfigurationtable1 GetConfigurationTable { get; set; }
    public Deletedesigntimepermission1 DeleteDesignTimePermission { get; set; }
    public Getremoteservicebinding1 GetRemoteServiceBinding { get; set; }
    public Purgepropertyhistory1 PurgePropertyHistory { get; set; }
    public Deletevisibilitypermission1 DeleteVisibilityPermission { get; set; }
    public Getpropertyvaluesvtqa1 GetPropertyValuesVTQA { get; set; }
    public Getintegerpropertyvalue1 GetIntegerPropertyValue { get; set; }
    public Geteffectivelocalpropertybinding1 GetEffectiveLocalPropertyBinding { get; set; }
    public Getpropertyvaluesasmultirowtable1 GetPropertyValuesAsMultiRowTable { get; set; }
}

public class Setlocalpropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects26 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype resultType { get; set; }
}

public class Parameterdefinitions
{
    public Propertyname propertyName { get; set; }
    public Aspects22 aspects { get; set; }
    public Sourcethingname sourceThingName { get; set; }
    public Sourcepropertyname sourcePropertyName { get; set; }
}

public class Propertyname
{
    public string name { get; set; }
    public Aspects21 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects21
{
}

public class Aspects22
{
    public string name { get; set; }
    public Aspects23 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects23
{
}

public class Sourcethingname
{
    public string name { get; set; }
    public Aspects24 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects24
{
}

public class Sourcepropertyname
{
    public string name { get; set; }
    public Aspects25 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects25
{
}

public class Aspects26
{
}

public class Resulttype
{
    public string name { get; set; }
    public Aspects27 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects27
{
}

public class Getbooleanpropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions1 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects29 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype1 resultType { get; set; }
}

public class Parameterdefinitions1
{
    public Propertyname1 propertyName { get; set; }
}

public class Propertyname1
{
    public string name { get; set; }
    public Aspects28 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects28
{
}

public class Aspects29
{
}

public class Resulttype1
{
    public string name { get; set; }
    public Aspects30 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects30
{
}

public class Getdesigntimepermissions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions2 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects31 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype2 resultType { get; set; }
}

public class Parameterdefinitions2
{
}

public class Aspects31
{
}

public class Resulttype2
{
    public string name { get; set; }
    public Aspects32 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects32
{
    public string dataShape { get; set; }
}

public class Getvaluestream1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions3 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects33 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype3 resultType { get; set; }
}

public class Parameterdefinitions3
{
}

public class Aspects33
{
}

public class Resulttype3
{
    public string name { get; set; }
    public Aspects34 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects34
{
}

public class Setmultirowconfigurationtable1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions4 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects38 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype4 resultType { get; set; }
}

public class Parameterdefinitions4
{
    public Configurationtable configurationTable { get; set; }
    public Persistent persistent { get; set; }
    public Tablename tableName { get; set; }
}

public class Configurationtable
{
    public string name { get; set; }
    public Aspects35 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects35
{
}

public class Persistent
{
    public string name { get; set; }
    public Aspects36 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects36
{
    public bool defaultValue { get; set; }
}

public class Tablename
{
    public string name { get; set; }
    public Aspects37 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects37
{
}

public class Aspects38
{
}

public class Resulttype4
{
    public string name { get; set; }
    public Aspects39 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects39
{
}

public class Addnumbervaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions5 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects43 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype5 resultType { get; set; }
}

public class Parameterdefinitions5
{
    public Propertyname2 propertyName { get; set; }
    public Value value { get; set; }
    public Timestamp timestamp { get; set; }
}

public class Propertyname2
{
    public string name { get; set; }
    public Aspects40 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects40
{
}

public class Value
{
    public string name { get; set; }
    public Aspects41 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects41
{
}

public class Timestamp
{
    public string name { get; set; }
    public Aspects42 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects42
{
}

public class Aspects43
{
}

public class Resulttype5
{
    public string name { get; set; }
    public Aspects44 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects44
{
}

public class Queryvec2propertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions6 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects51 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype6 resultType { get; set; }
}

public class Parameterdefinitions6
{
    public Oldestfirst oldestFirst { get; set; }
    public Maxitems maxItems { get; set; }
    public Enddate endDate { get; set; }
    public Propertyname3 propertyName { get; set; }
    public Query query { get; set; }
    public Startdate startDate { get; set; }
}

public class Oldestfirst
{
    public string name { get; set; }
    public Aspects45 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects45
{
}

public class Maxitems
{
    public string name { get; set; }
    public Aspects46 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects46
{
    public float defaultValue { get; set; }
}

public class Enddate
{
    public string name { get; set; }
    public Aspects47 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects47
{
}

public class Propertyname3
{
    public string name { get; set; }
    public Aspects48 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects48
{
}

public class Query
{
    public string name { get; set; }
    public Aspects49 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects49
{
}

public class Startdate
{
    public string name { get; set; }
    public Aspects50 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects50
{
}

public class Aspects51
{
}

public class Resulttype6
{
    public string name { get; set; }
    public Aspects52 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects52
{
    public string dataShape { get; set; }
}

public class Addeventdefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions7 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects59 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype7 resultType { get; set; }
}

public class Parameterdefinitions7
{
    public Remoteeventname remoteEventName { get; set; }
    public Name1 name { get; set; }
    public Description1 description { get; set; }
    public Category category { get; set; }
    public Remote remote { get; set; }
    public Datashape1 dataShape { get; set; }
}

public class Remoteeventname
{
    public string name { get; set; }
    public Aspects53 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects53
{
}

public class Name1
{
    public string name { get; set; }
    public Aspects54 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects54
{
}

public class Description1
{
    public string name { get; set; }
    public Aspects55 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects55
{
    public string defaultValue { get; set; }
}

public class Category
{
    public string name { get; set; }
    public Aspects56 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects56
{
}

public class Remote
{
    public string name { get; set; }
    public Aspects57 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects57
{
    public bool defaultValue { get; set; }
}

public class Datashape1
{
    public string name { get; set; }
    public Aspects58 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects58
{
}

public class Aspects59
{
}

public class Resulttype7
{
    public string name { get; set; }
    public Aspects60 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects60
{
}

public class Getvisibilitypermissions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions8 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects61 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype8 resultType { get; set; }
}

public class Parameterdefinitions8
{
}

public class Aspects61
{
}

public class Resulttype8
{
    public string name { get; set; }
    public Aspects62 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects62
{
    public string dataShape { get; set; }
}

public class Purgeallpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions9 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects65 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype9 resultType { get; set; }
}

public class Parameterdefinitions9
{
    public Enddate1 endDate { get; set; }
    public Startdate1 startDate { get; set; }
}

public class Enddate1
{
    public string name { get; set; }
    public Aspects63 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects63
{
}

public class Startdate1
{
    public string name { get; set; }
    public Aspects64 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects64
{
}

public class Aspects65
{
}

public class Resulttype9
{
    public string name { get; set; }
    public Aspects66 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects66
{
}

public class Addlocationvaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions10 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects70 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype10 resultType { get; set; }
}

public class Parameterdefinitions10
{
    public Propertyname4 propertyName { get; set; }
    public Value1 value { get; set; }
    public Timestamp1 timestamp { get; set; }
}

public class Propertyname4
{
    public string name { get; set; }
    public Aspects67 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects67
{
}

public class Value1
{
    public string name { get; set; }
    public Aspects68 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects68
{
}

public class Timestamp1
{
    public string name { get; set; }
    public Aspects69 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects69
{
}

public class Aspects70
{
}

public class Resulttype10
{
    public string name { get; set; }
    public Aspects71 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects71
{
}

public class Addvec3valuestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions11 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects75 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype11 resultType { get; set; }
}

public class Parameterdefinitions11
{
    public Propertyname5 propertyName { get; set; }
    public Value2 value { get; set; }
    public Timestamp2 timestamp { get; set; }
}

public class Propertyname5
{
    public string name { get; set; }
    public Aspects72 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects72
{
}

public class Value2
{
    public string name { get; set; }
    public Aspects73 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects73
{
}

public class Timestamp2
{
    public string name { get; set; }
    public Aspects74 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects74
{
}

public class Aspects75
{
}

public class Resulttype11
{
    public string name { get; set; }
    public Aspects76 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects76
{
}

public class Getruntimepermissions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions12 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects77 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype12 resultType { get; set; }
}

public class Parameterdefinitions12
{
}

public class Aspects77
{
}

public class Resulttype12
{
    public string name { get; set; }
    public Aspects78 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects78
{
    public string dataShape { get; set; }
}

public class Getvec3propertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions13 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects80 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype13 resultType { get; set; }
}

public class Parameterdefinitions13
{
    public Propertyname6 propertyName { get; set; }
}

public class Propertyname6
{
    public string name { get; set; }
    public Aspects79 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects79
{
}

public class Aspects80
{
}

public class Resulttype13
{
    public string name { get; set; }
    public Aspects81 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects81
{
}

public class Getmetadataasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions14 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects82 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype14 resultType { get; set; }
}

public class Parameterdefinitions14
{
}

public class Aspects82
{
}

public class Resulttype14
{
    public string name { get; set; }
    public Aspects83 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects83
{
}

public class Removeremoteservicebinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions15 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects85 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype15 resultType { get; set; }
}

public class Parameterdefinitions15
{
    public Servicename serviceName { get; set; }
}

public class Servicename
{
    public string name { get; set; }
    public Aspects84 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects84
{
}

public class Aspects85
{
}

public class Resulttype15
{
    public string name { get; set; }
    public Aspects86 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects86
{
}

public class Getthingsummaryinformation1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions16 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects87 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype16 resultType { get; set; }
}

public class Parameterdefinitions16
{
}

public class Aspects87
{
}

public class Resulttype16
{
    public string name { get; set; }
    public Aspects88 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects88
{
    public string dataShape { get; set; }
}

public class Getalertdefinitions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions17 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects90 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype17 resultType { get; set; }
}

public class Parameterdefinitions17
{
    public Property1 property { get; set; }
}

public class Property1
{
    public string name { get; set; }
    public Aspects89 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects89
{
}

public class Aspects90
{
}

public class Resulttype17
{
    public string name { get; set; }
    public Aspects91 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects91
{
    public string dataShape { get; set; }
}

public class Checkpermissionforuser1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions18 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects95 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype18 resultType { get; set; }
}

public class Parameterdefinitions18
{
    public Name2 name { get; set; }
    public Type type { get; set; }
    public User user { get; set; }
}

public class Name2
{
    public string name { get; set; }
    public Aspects92 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects92
{
}

public class Type
{
    public string name { get; set; }
    public Aspects93 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects93
{
}

public class User
{
    public string name { get; set; }
    public Aspects94 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects94
{
}

public class Aspects95
{
}

public class Resulttype18
{
    public string name { get; set; }
    public Aspects96 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects96
{
}

public class Acknowledgeallalerts1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions19 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects98 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype19 resultType { get; set; }
}

public class Parameterdefinitions19
{
    public Message message { get; set; }
}

public class Message
{
    public string name { get; set; }
    public Aspects97 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects97
{
}

public class Aspects98
{
}

public class Resulttype19
{
    public string name { get; set; }
    public Aspects99 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects99
{
}

public class Getimagepropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions20 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects101 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype20 resultType { get; set; }
}

public class Parameterdefinitions20
{
    public Propertyname7 propertyName { get; set; }
}

public class Propertyname7
{
    public string name { get; set; }
    public Aspects100 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects100
{
}

public class Aspects101
{
}

public class Resulttype20
{
    public string name { get; set; }
    public Aspects102 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects102
{
}

public class Setpublished1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions21 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects104 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype21 resultType { get; set; }
}

public class Parameterdefinitions21
{
    public Publish publish { get; set; }
}

public class Publish
{
    public string name { get; set; }
    public Aspects103 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects103
{
}

public class Aspects104
{
}

public class Resulttype21
{
    public string name { get; set; }
    public Aspects105 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects105
{
}

public class Getoutgoingdependencies1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions22 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects107 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype22 resultType { get; set; }
}

public class Parameterdefinitions22
{
    public Maxitems1 maxItems { get; set; }
}

public class Maxitems1
{
    public string name { get; set; }
    public Aspects106 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects106
{
    public float defaultValue { get; set; }
}

public class Aspects107
{
}

public class Resulttype22
{
    public string name { get; set; }
    public Aspects108 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects108
{
    public string dataShape { get; set; }
}

public class Querystringpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions23 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects115 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype23 resultType { get; set; }
}

public class Parameterdefinitions23
{
    public Oldestfirst1 oldestFirst { get; set; }
    public Maxitems2 maxItems { get; set; }
    public Enddate2 endDate { get; set; }
    public Propertyname8 propertyName { get; set; }
    public Query1 query { get; set; }
    public Startdate2 startDate { get; set; }
}

public class Oldestfirst1
{
    public string name { get; set; }
    public Aspects109 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects109
{
}

public class Maxitems2
{
    public string name { get; set; }
    public Aspects110 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects110
{
    public float defaultValue { get; set; }
}

public class Enddate2
{
    public string name { get; set; }
    public Aspects111 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects111
{
}

public class Propertyname8
{
    public string name { get; set; }
    public Aspects112 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects112
{
}

public class Query1
{
    public string name { get; set; }
    public Aspects113 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects113
{
}

public class Startdate2
{
    public string name { get; set; }
    public Aspects114 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects114
{
}

public class Aspects115
{
}

public class Resulttype23
{
    public string name { get; set; }
    public Aspects116 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects116
{
    public string dataShape { get; set; }
}

public class Getalertstatuses1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions24 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects117 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype24 resultType { get; set; }
}

public class Parameterdefinitions24
{
}

public class Aspects117
{
}

public class Resulttype24
{
    public string name { get; set; }
    public Aspects118 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects118
{
    public string dataShape { get; set; }
}

public class Getpublished1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions25 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects119 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype25 resultType { get; set; }
}

public class Parameterdefinitions25
{
}

public class Aspects119
{
}

public class Resulttype25
{
    public string name { get; set; }
    public Aspects120 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects120
{
}

public class Enableallalerts1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions26 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects122 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype26 resultType { get; set; }
}

public class Parameterdefinitions26
{
    public Persistent1 persistent { get; set; }
}

public class Persistent1
{
    public string name { get; set; }
    public Aspects121 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects121
{
    public bool defaultValue { get; set; }
}

public class Aspects122
{
}

public class Resulttype26
{
    public string name { get; set; }
    public Aspects123 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects123
{
}

public class Querybooleanpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions27 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects130 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype27 resultType { get; set; }
}

public class Parameterdefinitions27
{
    public Oldestfirst2 oldestFirst { get; set; }
    public Maxitems3 maxItems { get; set; }
    public Enddate3 endDate { get; set; }
    public Propertyname9 propertyName { get; set; }
    public Query2 query { get; set; }
    public Startdate3 startDate { get; set; }
}

public class Oldestfirst2
{
    public string name { get; set; }
    public Aspects124 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects124
{
}

public class Maxitems3
{
    public string name { get; set; }
    public Aspects125 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects125
{
    public float defaultValue { get; set; }
}

public class Enddate3
{
    public string name { get; set; }
    public Aspects126 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects126
{
}

public class Propertyname9
{
    public string name { get; set; }
    public Aspects127 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects127
{
}

public class Query2
{
    public string name { get; set; }
    public Aspects128 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects128
{
}

public class Startdate3
{
    public string name { get; set; }
    public Aspects129 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects129
{
}

public class Aspects130
{
}

public class Resulttype27
{
    public string name { get; set; }
    public Aspects131 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects131
{
    public string dataShape { get; set; }
}

public class Addruntimepermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions28 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects137 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype28 resultType { get; set; }
}

public class Parameterdefinitions28
{
    public Allow allow { get; set; }
    public Principal principal { get; set; }
    public Resource resource { get; set; }
    public Type1 type { get; set; }
    public Principaltype principalType { get; set; }
}

public class Allow
{
    public string name { get; set; }
    public Aspects132 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects132
{
}

public class Principal
{
    public string name { get; set; }
    public Aspects133 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects133
{
}

public class Resource
{
    public string name { get; set; }
    public Aspects134 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects134
{
}

public class Type1
{
    public string name { get; set; }
    public Aspects135 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects135
{
}

public class Principaltype
{
    public string name { get; set; }
    public Aspects136 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects136
{
}

public class Aspects137
{
}

public class Resulttype28
{
    public string name { get; set; }
    public Aspects138 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects138
{
}

public class Ismultirowtable1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions29 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects140 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype29 resultType { get; set; }
}

public class Parameterdefinitions29
{
    public Tablename1 tableName { get; set; }
}

public class Tablename1
{
    public string name { get; set; }
    public Aspects139 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects139
{
}

public class Aspects140
{
}

public class Resulttype29
{
    public string name { get; set; }
    public Aspects141 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects141
{
}

public class Ioservice1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions30 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects142 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype30 resultType { get; set; }
}

public class Parameterdefinitions30
{
}

public class Aspects142
{
    public bool isAsync { get; set; }
}

public class Resulttype30
{
    public string name { get; set; }
    public Aspects143 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects143
{
}

public class Removeremotepropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions31 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects145 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype31 resultType { get; set; }
}

public class Parameterdefinitions31
{
    public Propertyname10 propertyName { get; set; }
}

public class Propertyname10
{
    public string name { get; set; }
    public Aspects144 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects144
{
}

public class Aspects145
{
}

public class Resulttype31
{
    public string name { get; set; }
    public Aspects146 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects146
{
}

public class Geteffectivepropertylogging1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions32 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects148 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype32 resultType { get; set; }
}

public class Parameterdefinitions32
{
    public Propertyname11 propertyName { get; set; }
}

public class Propertyname11
{
    public string name { get; set; }
    public Aspects147 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects147
{
}

public class Aspects148
{
}

public class Resulttype32
{
    public string name { get; set; }
    public Aspects149 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects149
{
}

public class Getprojectname1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions33 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects150 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype33 resultType { get; set; }
}

public class Parameterdefinitions33
{
}

public class Aspects150
{
}

public class Resulttype33
{
    public string name { get; set; }
    public Aspects151 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects151
{
}

public class Getimplementedshapes1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions34 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects152 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype34 resultType { get; set; }
}

public class Parameterdefinitions34
{
}

public class Aspects152
{
}

public class Resulttype34
{
    public string name { get; set; }
    public Aspects153 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects153
{
    public string dataShape { get; set; }
}

public class Getthingcodepropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions35 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects155 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype35 resultType { get; set; }
}

public class Parameterdefinitions35
{
    public Propertyname12 propertyName { get; set; }
}

public class Propertyname12
{
    public string name { get; set; }
    public Aspects154 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects154
{
}

public class Aspects155
{
}

public class Resulttype35
{
    public string name { get; set; }
    public Aspects156 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects156
{
}

public class Updatepropertyvalues1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions36 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects158 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype36 resultType { get; set; }
}

public class Parameterdefinitions36
{
    public Values values { get; set; }
}

public class Values
{
    public string name { get; set; }
    public Aspects157 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects157
{
    public string dataShape { get; set; }
}

public class Aspects158
{
}

public class Resulttype36
{
    public string name { get; set; }
    public Aspects159 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects159
{
}

public class Deleteallconfigurationtablerows1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions37 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects162 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype37 resultType { get; set; }
}

public class Parameterdefinitions37
{
    public Persistent2 persistent { get; set; }
    public Tablename2 tableName { get; set; }
}

public class Persistent2
{
    public string name { get; set; }
    public Aspects160 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects160
{
    public bool defaultValue { get; set; }
}

public class Tablename2
{
    public string name { get; set; }
    public Aspects161 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects161
{
}

public class Aspects162
{
}

public class Resulttype37
{
    public string name { get; set; }
    public Aspects163 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects163
{
}

public class Addservicedefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions38 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects172 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype39 resultType { get; set; }
}

public class Parameterdefinitions38
{
    public Name3 name { get; set; }
    public Description2 description { get; set; }
    public Remoteservicename remoteServiceName { get; set; }
    public Category1 category { get; set; }
    public Remote1 remote { get; set; }
    public Parameters parameters { get; set; }
    public Resulttype38 resultType { get; set; }
    public Timeout timeout { get; set; }
}

public class Name3
{
    public string name { get; set; }
    public Aspects164 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects164
{
}

public class Description2
{
    public string name { get; set; }
    public Aspects165 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects165
{
    public string defaultValue { get; set; }
}

public class Remoteservicename
{
    public string name { get; set; }
    public Aspects166 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects166
{
}

public class Category1
{
    public string name { get; set; }
    public Aspects167 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects167
{
}

public class Remote1
{
    public string name { get; set; }
    public Aspects168 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects168
{
    public bool defaultValue { get; set; }
}

public class Parameters
{
    public string name { get; set; }
    public Aspects169 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects169
{
    public string dataShape { get; set; }
}

public class Resulttype38
{
    public string name { get; set; }
    public Aspects170 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects170
{
    public string dataShape { get; set; }
}

public class Timeout
{
    public string name { get; set; }
    public Aspects171 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects171
{
    public int defaultValue { get; set; }
}

public class Aspects172
{
}

public class Resulttype39
{
    public string name { get; set; }
    public Aspects173 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects173
{
}

public class Checkdesigntimepermissionforgroup1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions39 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects176 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype40 resultType { get; set; }
}

public class Parameterdefinitions39
{
    public Type2 type { get; set; }
    public Group group { get; set; }
}

public class Type2
{
    public string name { get; set; }
    public Aspects174 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects174
{
}

public class Group
{
    public string name { get; set; }
    public Aspects175 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects175
{
}

public class Aspects176
{
}

public class Resulttype40
{
    public string name { get; set; }
    public Aspects177 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects177
{
}

public class Addorupdatealert1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions40 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects186 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype41 resultType { get; set; }
}

public class Parameterdefinitions40
{
    public Alerttype alertType { get; set; }
    public Alertname alertName { get; set; }
    public Property2 property { get; set; }
    public Description3 description { get; set; }
    public Attributes attributes { get; set; }
    public Persistent3 persistent { get; set; }
    public Priority priority { get; set; }
    public Enabled enabled { get; set; }
}

public class Alerttype
{
    public string name { get; set; }
    public Aspects178 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects178
{
}

public class Alertname
{
    public string name { get; set; }
    public Aspects179 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects179
{
}

public class Property2
{
    public string name { get; set; }
    public Aspects180 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects180
{
}

public class Description3
{
    public string name { get; set; }
    public Aspects181 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects181
{
    public string defaultValue { get; set; }
}

public class Attributes
{
    public string name { get; set; }
    public Aspects182 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects182
{
}

public class Persistent3
{
    public string name { get; set; }
    public Aspects183 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects183
{
    public bool defaultValue { get; set; }
}

public class Priority
{
    public string name { get; set; }
    public Aspects184 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects184
{
    public int defaultValue { get; set; }
}

public class Enabled
{
    public string name { get; set; }
    public Aspects185 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects185
{
    public bool defaultValue { get; set; }
}

public class Aspects186
{
}

public class Resulttype41
{
    public string name { get; set; }
    public Aspects187 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects187
{
}

public class Queryalerthistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions41 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects193 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype42 resultType { get; set; }
}

public class Parameterdefinitions41
{
    public Oldestfirst3 oldestFirst { get; set; }
    public Maxitems4 maxItems { get; set; }
    public Enddate4 endDate { get; set; }
    public Query3 query { get; set; }
    public Startdate4 startDate { get; set; }
}

public class Oldestfirst3
{
    public string name { get; set; }
    public Aspects188 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects188
{
}

public class Maxitems4
{
    public string name { get; set; }
    public Aspects189 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects189
{
    public float defaultValue { get; set; }
}

public class Enddate4
{
    public string name { get; set; }
    public Aspects190 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects190
{
}

public class Query3
{
    public string name { get; set; }
    public Aspects191 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects191
{
}

public class Startdate4
{
    public string name { get; set; }
    public Aspects192 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects192
{
}

public class Aspects193
{
}

public class Resulttype42
{
    public string name { get; set; }
    public Aspects194 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects194
{
    public bool isStreamEntry { get; set; }
    public string dataShape { get; set; }
}

public class Checkdesigntimepermissionforuser1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions42 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects197 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype43 resultType { get; set; }
}

public class Parameterdefinitions42
{
    public Type3 type { get; set; }
    public User1 user { get; set; }
}

public class Type3
{
    public string name { get; set; }
    public Aspects195 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects195
{
}

public class User1
{
    public string name { get; set; }
    public Aspects196 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects196
{
}

public class Aspects197
{
}

public class Resulttype43
{
    public string name { get; set; }
    public Aspects198 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects198
{
}

public class Getdifferencesasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions43 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects200 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype44 resultType { get; set; }
}

public class Parameterdefinitions43
{
    public Otherentity otherEntity { get; set; }
}

public class Otherentity
{
    public string name { get; set; }
    public Aspects199 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects199
{
}

public class Aspects200
{
}

public class Resulttype44
{
    public string name { get; set; }
    public Aspects201 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects201
{
    public string dataShape { get; set; }
}

public class Addpropertydefinitions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions44 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects204 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype45 resultType { get; set; }
}

public class Parameterdefinitions44
{
    public Ignoreinvaliddefinitions ignoreInvalidDefinitions { get; set; }
    public Values1 values { get; set; }
}

public class Ignoreinvaliddefinitions
{
    public string name { get; set; }
    public Aspects202 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects202
{
    public bool defaultValue { get; set; }
}

public class Values1
{
    public string name { get; set; }
    public Aspects203 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects203
{
    public string dataShape { get; set; }
}

public class Aspects204
{
}

public class Resulttype45
{
    public string name { get; set; }
    public Aspects205 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects205
{
    public string dataShape { get; set; }
}

public class Disablealertsforproperty1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions45 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects209 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype46 resultType { get; set; }
}

public class Parameterdefinitions45
{
    public Alertname1 alertName { get; set; }
    public Property3 property { get; set; }
    public Persistent4 persistent { get; set; }
}

public class Alertname1
{
    public string name { get; set; }
    public Aspects206 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects206
{
}

public class Property3
{
    public string name { get; set; }
    public Aspects207 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects207
{
}

public class Persistent4
{
    public string name { get; set; }
    public Aspects208 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects208
{
    public bool defaultValue { get; set; }
}

public class Aspects209
{
}

public class Resulttype46
{
    public string name { get; set; }
    public Aspects210 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects210
{
}

public class Isenabled1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions46 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects211 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype47 resultType { get; set; }
}

public class Parameterdefinitions46
{
}

public class Aspects211
{
}

public class Resulttype47
{
    public string name { get; set; }
    public Aspects212 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects212
{
}

public class Implementsshape1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions47 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects214 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype48 resultType { get; set; }
}

public class Parameterdefinitions47
{
    public Thingshapename thingShapeName { get; set; }
}

public class Thingshapename
{
    public string name { get; set; }
    public Aspects213 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects213
{
}

public class Aspects214
{
}

public class Resulttype48
{
    public string name { get; set; }
    public Aspects215 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects215
{
}

public class Getpropertyvaluesvtq1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions48 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects216 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype49 resultType { get; set; }
}

public class Parameterdefinitions48
{
}

public class Aspects216
{
}

public class Resulttype49
{
    public string name { get; set; }
    public Aspects217 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects217
{
}

public class Setpropertylogging1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions49 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects220 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype50 resultType { get; set; }
}

public class Parameterdefinitions49
{
    public Propertyname13 propertyName { get; set; }
    public Enabled1 enabled { get; set; }
}

public class Propertyname13
{
    public string name { get; set; }
    public Aspects218 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects218
{
}

public class Enabled1
{
    public string name { get; set; }
    public Aspects219 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects219
{
}

public class Aspects220
{
}

public class Resulttype50
{
    public string name { get; set; }
    public Aspects221 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects221
{
}

public class Getdifferences1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions50 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects223 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype51 resultType { get; set; }
}

public class Parameterdefinitions50
{
    public Otherentity1 otherEntity { get; set; }
}

public class Otherentity1
{
    public string name { get; set; }
    public Aspects222 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects222
{
}

public class Aspects223
{
}

public class Resulttype51
{
    public string name { get; set; }
    public Aspects224 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects224
{
    public string dataShape { get; set; }
}

public class Addlongvaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions51 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects228 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype52 resultType { get; set; }
}

public class Parameterdefinitions51
{
    public Propertyname14 propertyName { get; set; }
    public Value3 value { get; set; }
    public Timestamp3 timestamp { get; set; }
}

public class Propertyname14
{
    public string name { get; set; }
    public Aspects225 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects225
{
}

public class Value3
{
    public string name { get; set; }
    public Aspects226 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects226
{
}

public class Timestamp3
{
    public string name { get; set; }
    public Aspects227 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects227
{
}

public class Aspects228
{
}

public class Resulttype52
{
    public string name { get; set; }
    public Aspects229 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects229
{
}

public class Addconfigurationtabledefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions52 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects237 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype53 resultType { get; set; }
}

public class Parameterdefinitions52
{
    public Ismultirow isMultiRow { get; set; }
    public Name4 name { get; set; }
    public Description4 description { get; set; }
    public Category2 category { get; set; }
    public Datashapename dataShapeName { get; set; }
    public Ishidden isHidden { get; set; }
    public Ordinal ordinal { get; set; }
}

public class Ismultirow
{
    public string name { get; set; }
    public Aspects230 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects230
{
    public bool defaultValue { get; set; }
}

public class Name4
{
    public string name { get; set; }
    public Aspects231 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects231
{
    public bool isRequired { get; set; }
}

public class Description4
{
    public string name { get; set; }
    public Aspects232 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects232
{
}

public class Category2
{
    public string name { get; set; }
    public Aspects233 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects233
{
}

public class Datashapename
{
    public string name { get; set; }
    public Aspects234 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects234
{
    public bool isRequired { get; set; }
}

public class Ishidden
{
    public string name { get; set; }
    public Aspects235 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects235
{
    public bool defaultValue { get; set; }
}

public class Ordinal
{
    public string name { get; set; }
    public Aspects236 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects236
{
    public int defaultValue { get; set; }
}

public class Aspects237
{
}

public class Resulttype53
{
    public string name { get; set; }
    public Aspects238 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects238
{
}

public class Getnumericloggedproperties1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions53 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects239 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype54 resultType { get; set; }
}

public class Parameterdefinitions53
{
}

public class Aspects239
{
}

public class Resulttype54
{
    public string name { get; set; }
    public Aspects240 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects240
{
    public string dataShape { get; set; }
}

public class Getnamedproperties1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions54 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects242 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype55 resultType { get; set; }
}

public class Parameterdefinitions54
{
    public Propertynames propertyNames { get; set; }
}

public class Propertynames
{
    public string name { get; set; }
    public Aspects241 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects241
{
}

public class Aspects242
{
}

public class Resulttype55
{
    public string name { get; set; }
    public Aspects243 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects243
{
}

public class Setremotepropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions55 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects253 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype56 resultType { get; set; }
}

public class Parameterdefinitions55
{
    public Propertyname15 propertyName { get; set; }
    public Aspects245 aspects { get; set; }
    public Pushthreshold pushThreshold { get; set; }
    public Foldtype foldType { get; set; }
    public Sourcepropertyname1 sourcePropertyName { get; set; }
    public Timeout1 timeout { get; set; }
    public Cachetime cacheTime { get; set; }
    public Pushtype pushType { get; set; }
}

public class Propertyname15
{
    public string name { get; set; }
    public Aspects244 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects244
{
}

public class Aspects245
{
    public string name { get; set; }
    public Aspects246 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects246
{
}

public class Pushthreshold
{
    public string name { get; set; }
    public Aspects247 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects247
{
}

public class Foldtype
{
    public string name { get; set; }
    public Aspects248 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects248
{
}

public class Sourcepropertyname1
{
    public string name { get; set; }
    public Aspects249 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects249
{
}

public class Timeout1
{
    public string name { get; set; }
    public Aspects250 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects250
{
    public int defaultValue { get; set; }
}

public class Cachetime
{
    public string name { get; set; }
    public Aspects251 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects251
{
}

public class Pushtype
{
    public string name { get; set; }
    public Aspects252 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects252
{
}

public class Aspects253
{
}

public class Resulttype56
{
    public string name { get; set; }
    public Aspects254 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects254
{
}

public class Geteventdefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions56 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects256 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype57 resultType { get; set; }
}

public class Parameterdefinitions56
{
    public Name5 name { get; set; }
}

public class Name5
{
    public string name { get; set; }
    public Aspects255 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects255
{
}

public class Aspects256
{
}

public class Resulttype57
{
    public string name { get; set; }
    public Aspects257 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects257
{
    public string dataShape { get; set; }
}

public class Restartthing1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions57 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects258 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype58 resultType { get; set; }
}

public class Parameterdefinitions57
{
}

public class Aspects258
{
}

public class Resulttype58
{
    public string name { get; set; }
    public Aspects259 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects259
{
}

public class Setintegeralertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions58 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects265 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype59 resultType { get; set; }
}

public class Parameterdefinitions58
{
    public Alertname2 alertName { get; set; }
    public Property4 property { get; set; }
    public Parametername parameterName { get; set; }
    public Persistent5 persistent { get; set; }
    public Value4 value { get; set; }
}

public class Alertname2
{
    public string name { get; set; }
    public Aspects260 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects260
{
}

public class Property4
{
    public string name { get; set; }
    public Aspects261 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects261
{
}

public class Parametername
{
    public string name { get; set; }
    public Aspects262 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects262
{
}

public class Persistent5
{
    public string name { get; set; }
    public Aspects263 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects263
{
    public bool defaultValue { get; set; }
}

public class Value4
{
    public string name { get; set; }
    public Aspects264 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects264
{
}

public class Aspects265
{
}

public class Resulttype59
{
    public string name { get; set; }
    public Aspects266 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects266
{
}

public class Addpropertydefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions59 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects284 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype60 resultType { get; set; }
}

public class Parameterdefinitions59
{
    public Defaultvalue defaultValue { get; set; }
    public Remotebindingaspects remoteBindingAspects { get; set; }
    public Description5 description { get; set; }
    public Readonly readOnly { get; set; }
    public Remote2 remote { get; set; }
    public Type4 type { get; set; }
    public Remotepropertyname remotePropertyName { get; set; }
    public Timeout2 timeout { get; set; }
    public Pushtype1 pushType { get; set; }
    public Datachangethreshold dataChangeThreshold { get; set; }
    public Logged logged { get; set; }
    public Name6 name { get; set; }
    public Pushthreshold1 pushThreshold { get; set; }
    public Datachangetype dataChangeType { get; set; }
    public Category3 category { get; set; }
    public Persistent6 persistent { get; set; }
    public Datashape2 dataShape { get; set; }
}

public class Defaultvalue
{
    public string name { get; set; }
    public Aspects267 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects267
{
}

public class Remotebindingaspects
{
    public string name { get; set; }
    public Aspects268 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects268
{
}

public class Description5
{
    public string name { get; set; }
    public Aspects269 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects269
{
    public string defaultValue { get; set; }
}

public class Readonly
{
    public string name { get; set; }
    public Aspects270 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects270
{
    public bool defaultValue { get; set; }
}

public class Remote2
{
    public string name { get; set; }
    public Aspects271 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects271
{
    public bool defaultValue { get; set; }
}

public class Type4
{
    public string name { get; set; }
    public Aspects272 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects272
{
}

public class Remotepropertyname
{
    public string name { get; set; }
    public Aspects273 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects273
{
}

public class Timeout2
{
    public string name { get; set; }
    public Aspects274 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects274
{
    public int defaultValue { get; set; }
}

public class Pushtype1
{
    public string name { get; set; }
    public Aspects275 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects275
{
}

public class Datachangethreshold
{
    public string name { get; set; }
    public Aspects276 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects276
{
}

public class Logged
{
    public string name { get; set; }
    public Aspects277 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects277
{
    public bool defaultValue { get; set; }
}

public class Name6
{
    public string name { get; set; }
    public Aspects278 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects278
{
}

public class Pushthreshold1
{
    public string name { get; set; }
    public Aspects279 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects279
{
}

public class Datachangetype
{
    public string name { get; set; }
    public Aspects280 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects280
{
}

public class Category3
{
    public string name { get; set; }
    public Aspects281 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects281
{
}

public class Persistent6
{
    public string name { get; set; }
    public Aspects282 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects282
{
    public bool defaultValue { get; set; }
}

public class Datashape2
{
    public string name { get; set; }
    public Aspects283 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects283
{
}

public class Aspects284
{
}

public class Resulttype60
{
    public string name { get; set; }
    public Aspects285 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects285
{
}

public class Getdatetimealertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions60 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects289 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype61 resultType { get; set; }
}

public class Parameterdefinitions60
{
    public Alertname3 alertName { get; set; }
    public Property5 property { get; set; }
    public Parametername1 parameterName { get; set; }
}

public class Alertname3
{
    public string name { get; set; }
    public Aspects286 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects286
{
}

public class Property5
{
    public string name { get; set; }
    public Aspects287 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects287
{
}

public class Parametername1
{
    public string name { get; set; }
    public Aspects288 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects288
{
}

public class Aspects289
{
}

public class Resulttype61
{
    public string name { get; set; }
    public Aspects290 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects290
{
}

public class Setconfigurationtable1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions61 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects294 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype62 resultType { get; set; }
}

public class Parameterdefinitions61
{
    public Configurationtable1 configurationTable { get; set; }
    public Persistent7 persistent { get; set; }
    public Tablename3 tableName { get; set; }
}

public class Configurationtable1
{
    public string name { get; set; }
    public Aspects291 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects291
{
}

public class Persistent7
{
    public string name { get; set; }
    public Aspects292 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects292
{
    public bool defaultValue { get; set; }
}

public class Tablename3
{
    public string name { get; set; }
    public Aspects293 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects293
{
}

public class Aspects294
{
}

public class Resulttype62
{
    public string name { get; set; }
    public Aspects295 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects295
{
}

public class Isinnetwork1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions62 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects297 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype63 resultType { get; set; }
}

public class Parameterdefinitions62
{
    public Network network { get; set; }
}

public class Network
{
    public string name { get; set; }
    public Aspects296 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects296
{
}

public class Aspects297
{
}

public class Resulttype63
{
    public string name { get; set; }
    public Aspects298 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects298
{
}

public class Removedynamicsubscription1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions63 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects303 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype64 resultType { get; set; }
}

public class Parameterdefinitions63
{
    public Propertyname16 propertyName { get; set; }
    public Eventname eventName { get; set; }
    public Thingname thingName { get; set; }
    public Servicename1 serviceName { get; set; }
}

public class Propertyname16
{
    public string name { get; set; }
    public Aspects299 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects299
{
}

public class Eventname
{
    public string name { get; set; }
    public Aspects300 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects300
{
}

public class Thingname
{
    public string name { get; set; }
    public Aspects301 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects301
{
}

public class Servicename1
{
    public string name { get; set; }
    public Aspects302 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects302
{
}

public class Aspects303
{
}

public class Resulttype64
{
    public string name { get; set; }
    public Aspects304 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects304
{
}

public class Removetags1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions64 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects306 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype65 resultType { get; set; }
}

public class Parameterdefinitions64
{
    public Tags1 tags { get; set; }
}

public class Tags1
{
    public string name { get; set; }
    public Aspects305 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects305
{
    public string tagType { get; set; }
}

public class Aspects306
{
}

public class Resulttype65
{
    public string name { get; set; }
    public Aspects307 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects307
{
}

public class Getnumberpropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions65 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects309 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype66 resultType { get; set; }
}

public class Parameterdefinitions65
{
    public Propertyname17 propertyName { get; set; }
}

public class Propertyname17
{
    public string name { get; set; }
    public Aspects308 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects308
{
}

public class Aspects309
{
}

public class Resulttype66
{
    public string name { get; set; }
    public Aspects310 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects310
{
}

public class Getavatar1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions66 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects311 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype67 resultType { get; set; }
}

public class Parameterdefinitions66
{
}

public class Aspects311
{
}

public class Resulttype67
{
    public string name { get; set; }
    public Aspects312 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects312
{
}

public class Getloggedproperties1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions67 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects314 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype68 resultType { get; set; }
}

public class Parameterdefinitions67
{
    public Type5 type { get; set; }
}

public class Type5
{
    public string name { get; set; }
    public Aspects313 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects313
{
}

public class Aspects314
{
}

public class Resulttype68
{
    public string name { get; set; }
    public Aspects315 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects315
{
    public string dataShape { get; set; }
}

public class Enablething1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions68 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects316 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype69 resultType { get; set; }
}

public class Parameterdefinitions68
{
}

public class Aspects316
{
}

public class Resulttype69
{
    public string name { get; set; }
    public Aspects317 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects317
{
}

public class Getservicedefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions69 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects319 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype70 resultType { get; set; }
}

public class Parameterdefinitions69
{
    public Name7 name { get; set; }
}

public class Name7
{
    public string name { get; set; }
    public Aspects318 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects318
{
}

public class Aspects319
{
}

public class Resulttype70
{
    public string name { get; set; }
    public Aspects320 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects320
{
    public string dataShape { get; set; }
}

public class Getconfigurationchangehistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions70 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects321 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype71 resultType { get; set; }
}

public class Parameterdefinitions70
{
}

public class Aspects321
{
}

public class Resulttype71
{
    public string name { get; set; }
    public Aspects322 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects322
{
    public string dataShape { get; set; }
}

public class Deleteruntimepermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions71 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects327 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype72 resultType { get; set; }
}

public class Parameterdefinitions71
{
    public Principal1 principal { get; set; }
    public Resource1 resource { get; set; }
    public Type6 type { get; set; }
    public Principaltype1 principalType { get; set; }
}

public class Principal1
{
    public string name { get; set; }
    public Aspects323 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects323
{
}

public class Resource1
{
    public string name { get; set; }
    public Aspects324 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects324
{
}

public class Type6
{
    public string name { get; set; }
    public Aspects325 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects325
{
}

public class Principaltype1
{
    public string name { get; set; }
    public Aspects326 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects326
{
}

public class Aspects327
{
}

public class Resulttype72
{
    public string name { get; set; }
    public Aspects328 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects328
{
}

public class Getconfigurationtablerow1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions72 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects331 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype73 resultType { get; set; }
}

public class Parameterdefinitions72
{
    public Key key { get; set; }
    public Tablename4 tableName { get; set; }
}

public class Key
{
    public string name { get; set; }
    public Aspects329 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects329
{
}

public class Tablename4
{
    public string name { get; set; }
    public Aspects330 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects330
{
}

public class Aspects331
{
}

public class Resulttype73
{
    public string name { get; set; }
    public Aspects332 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects332
{
}

public class Getstringpropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions73 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects334 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype74 resultType { get; set; }
}

public class Parameterdefinitions73
{
    public Propertyname18 propertyName { get; set; }
}

public class Propertyname18
{
    public string name { get; set; }
    public Aspects333 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects333
{
}

public class Aspects334
{
}

public class Resulttype74
{
    public string name { get; set; }
    public Aspects335 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects335
{
}

public class Getinstancemetadataasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions74 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects336 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype75 resultType { get; set; }
}

public class Parameterdefinitions74
{
}

public class Aspects336
{
}

public class Resulttype75
{
    public string name { get; set; }
    public Aspects337 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects337
{
}

public class Saveconfigurationtables1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions75 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects338 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype76 resultType { get; set; }
}

public class Parameterdefinitions75
{
}

public class Aspects338
{
}

public class Resulttype76
{
    public string name { get; set; }
    public Aspects339 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects339
{
}

public class Acknowledgealert1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions76 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects342 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype77 resultType { get; set; }
}

public class Parameterdefinitions76
{
    public Property6 property { get; set; }
    public Message1 message { get; set; }
}

public class Property6
{
    public string name { get; set; }
    public Aspects340 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects340
{
}

public class Message1
{
    public string name { get; set; }
    public Aspects341 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects341
{
}

public class Aspects342
{
}

public class Resulttype77
{
    public string name { get; set; }
    public Aspects343 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects343
{
}

public class Querylocationpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions77 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects350 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype78 resultType { get; set; }
}

public class Parameterdefinitions77
{
    public Oldestfirst4 oldestFirst { get; set; }
    public Maxitems5 maxItems { get; set; }
    public Enddate5 endDate { get; set; }
    public Propertyname19 propertyName { get; set; }
    public Query4 query { get; set; }
    public Startdate5 startDate { get; set; }
}

public class Oldestfirst4
{
    public string name { get; set; }
    public Aspects344 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects344
{
}

public class Maxitems5
{
    public string name { get; set; }
    public Aspects345 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects345
{
    public float defaultValue { get; set; }
}

public class Enddate5
{
    public string name { get; set; }
    public Aspects346 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects346
{
}

public class Propertyname19
{
    public string name { get; set; }
    public Aspects347 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects347
{
}

public class Query4
{
    public string name { get; set; }
    public Aspects348 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects348
{
}

public class Startdate5
{
    public string name { get; set; }
    public Aspects349 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects349
{
}

public class Aspects350
{
}

public class Resulttype78
{
    public string name { get; set; }
    public Aspects351 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects351
{
    public string dataShape { get; set; }
}

public class Queryvec4propertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions78 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects358 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype79 resultType { get; set; }
}

public class Parameterdefinitions78
{
    public Oldestfirst5 oldestFirst { get; set; }
    public Maxitems6 maxItems { get; set; }
    public Enddate6 endDate { get; set; }
    public Propertyname20 propertyName { get; set; }
    public Query5 query { get; set; }
    public Startdate6 startDate { get; set; }
}

public class Oldestfirst5
{
    public string name { get; set; }
    public Aspects352 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects352
{
}

public class Maxitems6
{
    public string name { get; set; }
    public Aspects353 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects353
{
    public float defaultValue { get; set; }
}

public class Enddate6
{
    public string name { get; set; }
    public Aspects354 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects354
{
}

public class Propertyname20
{
    public string name { get; set; }
    public Aspects355 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects355
{
}

public class Query5
{
    public string name { get; set; }
    public Aspects356 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects356
{
}

public class Startdate6
{
    public string name { get; set; }
    public Aspects357 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects357
{
}

public class Aspects358
{
}

public class Resulttype79
{
    public string name { get; set; }
    public Aspects359 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects359
{
    public string dataShape { get; set; }
}

public class Setremoteservicebinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions79 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects363 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype80 resultType { get; set; }
}

public class Parameterdefinitions79
{
    public Sourceservicename sourceServiceName { get; set; }
    public Servicename2 serviceName { get; set; }
    public Timeout3 timeout { get; set; }
}

public class Sourceservicename
{
    public string name { get; set; }
    public Aspects360 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects360
{
}

public class Servicename2
{
    public string name { get; set; }
    public Aspects361 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects361
{
}

public class Timeout3
{
    public string name { get; set; }
    public Aspects362 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects362
{
    public int defaultValue { get; set; }
}

public class Aspects363
{
}

public class Resulttype80
{
    public string name { get; set; }
    public Aspects364 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects364
{
}

public class Isderivedfromtemplate1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions80 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects366 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype81 resultType { get; set; }
}

public class Parameterdefinitions80
{
    public Thingtemplatename thingTemplateName { get; set; }
}

public class Thingtemplatename
{
    public string name { get; set; }
    public Aspects365 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects365
{
}

public class Aspects366
{
}

public class Resulttype81
{
    public string name { get; set; }
    public Aspects367 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects367
{
}

public class Writepropertiestostream1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions81 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects370 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype82 resultType { get; set; }
}

public class Parameterdefinitions81
{
    public Name8 name { get; set; }
    public Tags2 tags { get; set; }
}

public class Name8
{
    public string name { get; set; }
    public Aspects368 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects368
{
    public string thingTemplate { get; set; }
}

public class Tags2
{
    public string name { get; set; }
    public Aspects369 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects369
{
    public string tagType { get; set; }
}

public class Aspects370
{
}

public class Resulttype82
{
    public string name { get; set; }
    public Aspects371 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects371
{
}

public class Getthingrelationships1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions82 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects373 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype83 resultType { get; set; }
}

public class Parameterdefinitions82
{
    public Maxdepth maxDepth { get; set; }
}

public class Maxdepth
{
    public string name { get; set; }
    public Aspects372 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects372
{
}

public class Aspects373
{
}

public class Resulttype83
{
    public string name { get; set; }
    public Aspects374 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects374
{
    public string dataShape { get; set; }
}

public class Getconfigurationtables1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions83 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects375 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype84 resultType { get; set; }
}

public class Parameterdefinitions83
{
}

public class Aspects375
{
}

public class Resulttype84
{
    public string name { get; set; }
    public Aspects376 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects376
{
    public string dataShape { get; set; }
}

public class Addvec4valuestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions84 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects380 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype85 resultType { get; set; }
}

public class Parameterdefinitions84
{
    public Propertyname21 propertyName { get; set; }
    public Value5 value { get; set; }
    public Timestamp4 timestamp { get; set; }
}

public class Propertyname21
{
    public string name { get; set; }
    public Aspects377 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects377
{
}

public class Value5
{
    public string name { get; set; }
    public Aspects378 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects378
{
}

public class Timestamp4
{
    public string name { get; set; }
    public Aspects379 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects379
{
}

public class Aspects380
{
}

public class Resulttype85
{
    public string name { get; set; }
    public Aspects381 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects381
{
}

public class Adddatetimevaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions85 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects385 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype86 resultType { get; set; }
}

public class Parameterdefinitions85
{
    public Propertyname22 propertyName { get; set; }
    public Value6 value { get; set; }
    public Timestamp5 timestamp { get; set; }
}

public class Propertyname22
{
    public string name { get; set; }
    public Aspects382 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects382
{
}

public class Value6
{
    public string name { get; set; }
    public Aspects383 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects383
{
}

public class Timestamp5
{
    public string name { get; set; }
    public Aspects384 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects384
{
}

public class Aspects385
{
}

public class Resulttype86
{
    public string name { get; set; }
    public Aspects386 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects386
{
}

public class Getservicedefinitions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions86 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects390 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype87 resultType { get; set; }
}

public class Parameterdefinitions86
{
    public Category4 category { get; set; }
    public Type7 type { get; set; }
    public Datashape3 dataShape { get; set; }
}

public class Category4
{
    public string name { get; set; }
    public Aspects387 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects387
{
}

public class Type7
{
    public string name { get; set; }
    public Aspects388 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects388
{
}

public class Datashape3
{
    public string name { get; set; }
    public Aspects389 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects389
{
}

public class Aspects390
{
}

public class Resulttype87
{
    public string name { get; set; }
    public Aspects391 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects391
{
    public string dataShape { get; set; }
}

public class Purgeselectedpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions87 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects395 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype88 resultType { get; set; }
}

public class Parameterdefinitions87
{
    public Propertiestopurge propertiesToPurge { get; set; }
    public Enddate7 endDate { get; set; }
    public Startdate7 startDate { get; set; }
}

public class Propertiestopurge
{
    public string name { get; set; }
    public Aspects392 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects392
{
    public string dataShape { get; set; }
}

public class Enddate7
{
    public string name { get; set; }
    public Aspects393 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects393
{
}

public class Startdate7
{
    public string name { get; set; }
    public Aspects394 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects394
{
}

public class Aspects395
{
}

public class Resulttype88
{
    public string name { get; set; }
    public Aspects396 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects396
{
}

public class Sethomemashup1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions88 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects398 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype89 resultType { get; set; }
}

public class Parameterdefinitions88
{
    public Name9 name { get; set; }
}

public class Name9
{
    public string name { get; set; }
    public Aspects397 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects397
{
}

public class Aspects398
{
}

public class Resulttype89
{
    public string name { get; set; }
    public Aspects399 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects399
{
}

public class Setowner1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions89 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects401 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype90 resultType { get; set; }
}

public class Parameterdefinitions89
{
    public Name10 name { get; set; }
}

public class Name10
{
    public string name { get; set; }
    public Aspects400 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects400
{
}

public class Aspects401
{
}

public class Resulttype90
{
    public string name { get; set; }
    public Aspects402 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects402
{
}

public class Querynumberpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions90 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects409 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype91 resultType { get; set; }
}

public class Parameterdefinitions90
{
    public Oldestfirst6 oldestFirst { get; set; }
    public Maxitems7 maxItems { get; set; }
    public Enddate8 endDate { get; set; }
    public Propertyname23 propertyName { get; set; }
    public Query6 query { get; set; }
    public Startdate8 startDate { get; set; }
}

public class Oldestfirst6
{
    public string name { get; set; }
    public Aspects403 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects403
{
}

public class Maxitems7
{
    public string name { get; set; }
    public Aspects404 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects404
{
    public float defaultValue { get; set; }
}

public class Enddate8
{
    public string name { get; set; }
    public Aspects405 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects405
{
}

public class Propertyname23
{
    public string name { get; set; }
    public Aspects406 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects406
{
}

public class Query6
{
    public string name { get; set; }
    public Aspects407 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects407
{
}

public class Startdate8
{
    public string name { get; set; }
    public Aspects408 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects408
{
}

public class Aspects409
{
}

public class Resulttype91
{
    public string name { get; set; }
    public Aspects410 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects410
{
    public string dataShape { get; set; }
}

public class Setnumberalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions91 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects416 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype92 resultType { get; set; }
}

public class Parameterdefinitions91
{
    public Alertname4 alertName { get; set; }
    public Property7 property { get; set; }
    public Parametername2 parameterName { get; set; }
    public Persistent8 persistent { get; set; }
    public Value7 value { get; set; }
}

public class Alertname4
{
    public string name { get; set; }
    public Aspects411 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects411
{
}

public class Property7
{
    public string name { get; set; }
    public Aspects412 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects412
{
}

public class Parametername2
{
    public string name { get; set; }
    public Aspects413 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects413
{
}

public class Persistent8
{
    public string name { get; set; }
    public Aspects414 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects414
{
    public bool defaultValue { get; set; }
}

public class Value7
{
    public string name { get; set; }
    public Aspects415 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects415
{
}

public class Aspects416
{
}

public class Resulttype92
{
    public string name { get; set; }
    public Aspects417 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects417
{
}

public class Gethomemashup1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions92 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects418 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype93 resultType { get; set; }
}

public class Parameterdefinitions92
{
}

public class Aspects418
{
}

public class Resulttype93
{
    public string name { get; set; }
    public Aspects419 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects419
{
}

public class Gettags1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions93 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects420 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype94 resultType { get; set; }
}

public class Parameterdefinitions93
{
}

public class Aspects420
{
}

public class Resulttype94
{
    public string name { get; set; }
    public Aspects421 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects421
{
    public string tagType { get; set; }
}

public class Getalertstatus1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions94 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects424 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype95 resultType { get; set; }
}

public class Parameterdefinitions94
{
    public Alertname5 alertName { get; set; }
    public Property8 property { get; set; }
}

public class Alertname5
{
    public string name { get; set; }
    public Aspects422 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects422
{
}

public class Property8
{
    public string name { get; set; }
    public Aspects423 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects423
{
}

public class Aspects424
{
}

public class Resulttype95
{
    public string name { get; set; }
    public Aspects425 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects425
{
}

public class Setbooleanalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions95 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects431 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype96 resultType { get; set; }
}

public class Parameterdefinitions95
{
    public Alertname6 alertName { get; set; }
    public Property9 property { get; set; }
    public Parametername3 parameterName { get; set; }
    public Persistent9 persistent { get; set; }
    public Value8 value { get; set; }
}

public class Alertname6
{
    public string name { get; set; }
    public Aspects426 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects426
{
}

public class Property9
{
    public string name { get; set; }
    public Aspects427 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects427
{
}

public class Parametername3
{
    public string name { get; set; }
    public Aspects428 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects428
{
}

public class Persistent9
{
    public string name { get; set; }
    public Aspects429 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects429
{
    public bool defaultValue { get; set; }
}

public class Value8
{
    public string name { get; set; }
    public Aspects430 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects430
{
}

public class Aspects431
{
}

public class Resulttype96
{
    public string name { get; set; }
    public Aspects432 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects432
{
}

public class Getnetworks1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions96 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects433 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype97 resultType { get; set; }
}

public class Parameterdefinitions96
{
}

public class Aspects433
{
}

public class Resulttype97
{
    public string name { get; set; }
    public Aspects434 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects434
{
    public string dataShape { get; set; }
}

public class Deleteconfigurationtable1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions97 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects437 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype98 resultType { get; set; }
}

public class Parameterdefinitions97
{
    public Persistent10 persistent { get; set; }
    public Tablename5 tableName { get; set; }
}

public class Persistent10
{
    public string name { get; set; }
    public Aspects435 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects435
{
    public bool defaultValue { get; set; }
}

public class Tablename5
{
    public string name { get; set; }
    public Aspects436 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects436
{
}

public class Aspects437
{
}

public class Resulttype98
{
    public string name { get; set; }
    public Aspects438 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects438
{
}

public class Getpermissionsforcurrentuser1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions98 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects441 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype99 resultType { get; set; }
}

public class Parameterdefinitions98
{
    public Name11 name { get; set; }
    public Permissionname permissionName { get; set; }
}

public class Name11
{
    public string name { get; set; }
    public Aspects439 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects439
{
}

public class Permissionname
{
    public string name { get; set; }
    public Aspects440 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects440
{
}

public class Aspects441
{
}

public class Resulttype99
{
    public string name { get; set; }
    public Aspects442 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects442
{
    public string dataShape { get; set; }
}

public class Gettagsasinfotable1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions99 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects443 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype100 resultType { get; set; }
}

public class Parameterdefinitions99
{
}

public class Aspects443
{
}

public class Resulttype100
{
    public string name { get; set; }
    public Aspects444 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects444
{
    public string dataShape { get; set; }
}

public class Checkdesigntimepermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions100 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects446 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype101 resultType { get; set; }
}

public class Parameterdefinitions100
{
    public Type8 type { get; set; }
}

public class Type8
{
    public string name { get; set; }
    public Aspects445 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects445
{
}

public class Aspects446
{
}

public class Resulttype101
{
    public string name { get; set; }
    public Aspects447 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects447
{
}

public class Getconfigurationtabledefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions101 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects449 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype102 resultType { get; set; }
}

public class Parameterdefinitions101
{
    public Tablename6 tableName { get; set; }
}

public class Tablename6
{
    public string name { get; set; }
    public Aspects448 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects448
{
}

public class Aspects449
{
}

public class Resulttype102
{
    public string name { get; set; }
    public Aspects450 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects450
{
}

public class Querypropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions102 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects456 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype103 resultType { get; set; }
}

public class Parameterdefinitions102
{
    public Oldestfirst7 oldestFirst { get; set; }
    public Maxitems8 maxItems { get; set; }
    public Enddate9 endDate { get; set; }
    public Query7 query { get; set; }
    public Startdate9 startDate { get; set; }
}

public class Oldestfirst7
{
    public string name { get; set; }
    public Aspects451 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects451
{
}

public class Maxitems8
{
    public string name { get; set; }
    public Aspects452 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects452
{
    public float defaultValue { get; set; }
}

public class Enddate9
{
    public string name { get; set; }
    public Aspects453 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects453
{
}

public class Query7
{
    public string name { get; set; }
    public Aspects454 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects454
{
}

public class Startdate9
{
    public string name { get; set; }
    public Aspects455 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects455
{
}

public class Aspects456
{
}

public class Resulttype103
{
    public string name { get; set; }
    public Aspects457 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects457
{
}

public class Getvec2propertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions103 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects459 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype104 resultType { get; set; }
}

public class Parameterdefinitions103
{
    public Propertyname24 propertyName { get; set; }
}

public class Propertyname24
{
    public string name { get; set; }
    public Aspects458 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects458
{
}

public class Aspects459
{
}

public class Resulttype104
{
    public string name { get; set; }
    public Aspects460 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects460
{
}

public class Querylongpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions104 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects467 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype105 resultType { get; set; }
}

public class Parameterdefinitions104
{
    public Oldestfirst8 oldestFirst { get; set; }
    public Maxitems9 maxItems { get; set; }
    public Enddate10 endDate { get; set; }
    public Propertyname25 propertyName { get; set; }
    public Query8 query { get; set; }
    public Startdate10 startDate { get; set; }
}

public class Oldestfirst8
{
    public string name { get; set; }
    public Aspects461 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects461
{
}

public class Maxitems9
{
    public string name { get; set; }
    public Aspects462 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects462
{
    public float defaultValue { get; set; }
}

public class Enddate10
{
    public string name { get; set; }
    public Aspects463 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects463
{
}

public class Propertyname25
{
    public string name { get; set; }
    public Aspects464 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects464
{
}

public class Query8
{
    public string name { get; set; }
    public Aspects465 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects465
{
}

public class Startdate10
{
    public string name { get; set; }
    public Aspects466 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects466
{
}

public class Aspects467
{
}

public class Resulttype105
{
    public string name { get; set; }
    public Aspects468 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects468
{
    public string dataShape { get; set; }
}

public class Removelocalpropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions105 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects470 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype106 resultType { get; set; }
}

public class Parameterdefinitions105
{
    public Propertyname26 propertyName { get; set; }
}

public class Propertyname26
{
    public string name { get; set; }
    public Aspects469 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects469
{
}

public class Aspects470
{
}

public class Resulttype106
{
    public string name { get; set; }
    public Aspects471 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects471
{
}

public class Setdesigntimepermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions106 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects473 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype107 resultType { get; set; }
}

public class Parameterdefinitions106
{
    public Permissions permissions { get; set; }
}

public class Permissions
{
    public string name { get; set; }
    public Aspects472 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects472
{
}

public class Aspects473
{
}

public class Resulttype107
{
    public string name { get; set; }
    public Aspects474 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects474
{
}

public class Hasoutgoingdependencies1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions107 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects475 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype108 resultType { get; set; }
}

public class Parameterdefinitions107
{
}

public class Aspects475
{
}

public class Resulttype108
{
    public string name { get; set; }
    public Aspects476 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects476
{
}

public class Getremoteeventbinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions108 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects478 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype109 resultType { get; set; }
}

public class Parameterdefinitions108
{
    public Eventname1 eventName { get; set; }
}

public class Eventname1
{
    public string name { get; set; }
    public Aspects477 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects477
{
}

public class Aspects478
{
}

public class Resulttype109
{
    public string name { get; set; }
    public Aspects479 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects479
{
    public string dataShape { get; set; }
}

public class Getpermissionsforgroup1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions109 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects483 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype110 resultType { get; set; }
}

public class Parameterdefinitions109
{
    public Name12 name { get; set; }
    public Group1 group { get; set; }
    public Permissionname1 permissionName { get; set; }
}

public class Name12
{
    public string name { get; set; }
    public Aspects480 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects480
{
}

public class Group1
{
    public string name { get; set; }
    public Aspects481 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects481
{
}

public class Permissionname1
{
    public string name { get; set; }
    public Aspects482 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects482
{
}

public class Aspects483
{
}

public class Resulttype110
{
    public string name { get; set; }
    public Aspects484 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects484
{
    public string dataShape { get; set; }
}

public class Addintegervaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions110 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects488 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype111 resultType { get; set; }
}

public class Parameterdefinitions110
{
    public Propertyname27 propertyName { get; set; }
    public Value9 value { get; set; }
    public Timestamp6 timestamp { get; set; }
}

public class Propertyname27
{
    public string name { get; set; }
    public Aspects485 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects485
{
}

public class Value9
{
    public string name { get; set; }
    public Aspects486 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects486
{
}

public class Timestamp6
{
    public string name { get; set; }
    public Aspects487 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects487
{
}

public class Aspects488
{
}

public class Resulttype111
{
    public string name { get; set; }
    public Aspects489 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects489
{
}

public class Getremotepropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions111 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects491 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype112 resultType { get; set; }
}

public class Parameterdefinitions111
{
    public Propertyname28 propertyName { get; set; }
}

public class Propertyname28
{
    public string name { get; set; }
    public Aspects490 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects490
{
}

public class Aspects491
{
}

public class Resulttype112
{
    public string name { get; set; }
    public Aspects492 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects492
{
    public string dataShape { get; set; }
}

public class Getmetadatawithpermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions112 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects493 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype113 resultType { get; set; }
}

public class Parameterdefinitions112
{
}

public class Aspects493
{
}

public class Resulttype113
{
    public string name { get; set; }
    public Aspects494 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects494
{
}

public class Settags1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions113 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects496 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype114 resultType { get; set; }
}

public class Parameterdefinitions113
{
    public Tags3 tags { get; set; }
}

public class Tags3
{
    public string name { get; set; }
    public Aspects495 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects495
{
    public string tagType { get; set; }
}

public class Aspects496
{
}

public class Resulttype114
{
    public string name { get; set; }
    public Aspects497 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects497
{
}

public class Getincomingdependencies1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions114 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects499 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype115 resultType { get; set; }
}

public class Parameterdefinitions114
{
    public Maxitems10 maxItems { get; set; }
}

public class Maxitems10
{
    public string name { get; set; }
    public Aspects498 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects498
{
    public float defaultValue { get; set; }
}

public class Aspects499
{
}

public class Resulttype115
{
    public string name { get; set; }
    public Aspects500 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects500
{
    public string dataShape { get; set; }
}

public class Getmetadata1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions115 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects501 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype116 resultType { get; set; }
}

public class Parameterdefinitions115
{
}

public class Aspects501
{
}

public class Resulttype116
{
    public string name { get; set; }
    public Aspects502 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects502
{
}

public class Getlocallyimplementedshapes1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions116 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects503 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype117 resultType { get; set; }
}

public class Parameterdefinitions116
{
}

public class Aspects503
{
}

public class Resulttype117
{
    public string name { get; set; }
    public Aspects504 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects504
{
    public string dataShape { get; set; }
}

public class Promotealert1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions117 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects507 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype118 resultType { get; set; }
}

public class Parameterdefinitions117
{
    public Alertname7 alertName { get; set; }
    public Propertyname29 propertyName { get; set; }
}

public class Alertname7
{
    public string name { get; set; }
    public Aspects505 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects505
{
}

public class Propertyname29
{
    public string name { get; set; }
    public Aspects506 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects506
{
}

public class Aspects507
{
}

public class Resulttype118
{
    public string name { get; set; }
    public Aspects508 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects508
{
}

public class Addtags1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions118 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects510 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype119 resultType { get; set; }
}

public class Parameterdefinitions118
{
    public Tags4 tags { get; set; }
}

public class Tags4
{
    public string name { get; set; }
    public Aspects509 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects509
{
    public string tagType { get; set; }
}

public class Aspects510
{
}

public class Resulttype119
{
    public string name { get; set; }
    public Aspects511 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects511
{
}

public class Getpermissionsforuser1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions119 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects515 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype120 resultType { get; set; }
}

public class Parameterdefinitions119
{
    public Name13 name { get; set; }
    public User2 user { get; set; }
    public Permissionname2 permissionName { get; set; }
}

public class Name13
{
    public string name { get; set; }
    public Aspects512 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects512
{
}

public class User2
{
    public string name { get; set; }
    public Aspects513 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects513
{
}

public class Permissionname2
{
    public string name { get; set; }
    public Aspects514 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects514
{
}

public class Aspects515
{
}

public class Resulttype120
{
    public string name { get; set; }
    public Aspects516 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects516
{
    public string dataShape { get; set; }
}

public class Addbooleanvaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions120 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects520 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype121 resultType { get; set; }
}

public class Parameterdefinitions120
{
    public Propertyname30 propertyName { get; set; }
    public Value10 value { get; set; }
    public Timestamp7 timestamp { get; set; }
}

public class Propertyname30
{
    public string name { get; set; }
    public Aspects517 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects517
{
}

public class Value10
{
    public string name { get; set; }
    public Aspects518 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects518
{
}

public class Timestamp7
{
    public string name { get; set; }
    public Aspects519 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects519
{
}

public class Aspects520
{
}

public class Resulttype121
{
    public string name { get; set; }
    public Aspects521 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects521
{
}

public class Getnamedpropertyvalues1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions121 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects523 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype122 resultType { get; set; }
}

public class Parameterdefinitions121
{
    public Propertynames1 propertyNames { get; set; }
}

public class Propertynames1
{
    public string name { get; set; }
    public Aspects522 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects522
{
    public string dataShape { get; set; }
}

public class Aspects523
{
}

public class Resulttype122
{
    public string name { get; set; }
    public Aspects524 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects524
{
}

public class Checkpermissionforgroup1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions122 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects528 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype123 resultType { get; set; }
}

public class Parameterdefinitions122
{
    public Name14 name { get; set; }
    public Type9 type { get; set; }
    public Group2 group { get; set; }
}

public class Name14
{
    public string name { get; set; }
    public Aspects525 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects525
{
}

public class Type9
{
    public string name { get; set; }
    public Aspects526 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects526
{
}

public class Group2
{
    public string name { get; set; }
    public Aspects527 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects527
{
}

public class Aspects528
{
}

public class Resulttype123
{
    public string name { get; set; }
    public Aspects529 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects529
{
}

public class Getdesigntimepermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions123 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects530 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype124 resultType { get; set; }
}

public class Parameterdefinitions123
{
}

public class Aspects530
{
}

public class Resulttype124
{
    public string name { get; set; }
    public Aspects531 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects531
{
}

public class Setidentifier1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions124 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects533 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype125 resultType { get; set; }
}

public class Parameterdefinitions124
{
    public Identifier identifier { get; set; }
}

public class Identifier
{
    public string name { get; set; }
    public Aspects532 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects532
{
}

public class Aspects533
{
}

public class Resulttype125
{
    public string name { get; set; }
    public Aspects534 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects534
{
}

public class Getdatetimepropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions125 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects536 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype126 resultType { get; set; }
}

public class Parameterdefinitions125
{
    public Propertyname31 propertyName { get; set; }
}

public class Propertyname31
{
    public string name { get; set; }
    public Aspects535 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects535
{
}

public class Aspects536
{
}

public class Resulttype126
{
    public string name { get; set; }
    public Aspects537 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects537
{
}

public class Disablesubscription1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions126 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects541 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype127 resultType { get; set; }
}

public class Parameterdefinitions126
{
    public Propertyname32 propertyName { get; set; }
    public Eventname2 eventName { get; set; }
    public Thingname1 thingName { get; set; }
}

public class Propertyname32
{
    public string name { get; set; }
    public Aspects538 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects538
{
}

public class Eventname2
{
    public string name { get; set; }
    public Aspects539 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects539
{
}

public class Thingname1
{
    public string name { get; set; }
    public Aspects540 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects540
{
}

public class Aspects541
{
}

public class Resulttype127
{
    public string name { get; set; }
    public Aspects542 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects542
{
}

public class Getanomalyalerttrainingstatisticsforalert1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions127 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects545 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype128 resultType { get; set; }
}

public class Parameterdefinitions127
{
    public Alertname8 alertName { get; set; }
    public Property10 property { get; set; }
}

public class Alertname8
{
    public string name { get; set; }
    public Aspects543 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects543
{
}

public class Property10
{
    public string name { get; set; }
    public Aspects544 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects544
{
}

public class Aspects545
{
}

public class Resulttype128
{
    public string name { get; set; }
    public Aspects546 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects546
{
    public string dataShape { get; set; }
}

public class Havepropertieschangedsince1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions128 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects548 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype129 resultType { get; set; }
}

public class Parameterdefinitions128
{
    public Timestamp8 timestamp { get; set; }
}

public class Timestamp8
{
    public string name { get; set; }
    public Aspects547 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects547
{
}

public class Aspects548
{
}

public class Resulttype129
{
    public string name { get; set; }
    public Aspects549 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects549
{
}

public class Getidentifier1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions129 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects550 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype130 resultType { get; set; }
}

public class Parameterdefinitions129
{
}

public class Aspects550
{
}

public class Resulttype130
{
    public string name { get; set; }
    public Aspects551 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects551
{
}

public class Queryimagepropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions130 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects558 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype131 resultType { get; set; }
}

public class Parameterdefinitions130
{
    public Oldestfirst9 oldestFirst { get; set; }
    public Maxitems11 maxItems { get; set; }
    public Enddate11 endDate { get; set; }
    public Propertyname33 propertyName { get; set; }
    public Query9 query { get; set; }
    public Startdate11 startDate { get; set; }
}

public class Oldestfirst9
{
    public string name { get; set; }
    public Aspects552 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects552
{
}

public class Maxitems11
{
    public string name { get; set; }
    public Aspects553 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects553
{
    public float defaultValue { get; set; }
}

public class Enddate11
{
    public string name { get; set; }
    public Aspects554 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects554
{
}

public class Propertyname33
{
    public string name { get; set; }
    public Aspects555 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects555
{
}

public class Query9
{
    public string name { get; set; }
    public Aspects556 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects556
{
}

public class Startdate11
{
    public string name { get; set; }
    public Aspects557 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects557
{
}

public class Aspects558
{
}

public class Resulttype131
{
    public string name { get; set; }
    public Aspects559 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects559
{
    public string dataShape { get; set; }
}

public class Setvisibilitypermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions131 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects561 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype132 resultType { get; set; }
}

public class Parameterdefinitions131
{
    public Permissions1 permissions { get; set; }
}

public class Permissions1
{
    public string name { get; set; }
    public Aspects560 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects560
{
}

public class Aspects561
{
}

public class Resulttype132
{
    public string name { get; set; }
    public Aspects562 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects562
{
}

public class Getalertdefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions132 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects565 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype133 resultType { get; set; }
}

public class Parameterdefinitions132
{
    public Alertname9 alertName { get; set; }
    public Property11 property { get; set; }
}

public class Alertname9
{
    public string name { get; set; }
    public Aspects563 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects563
{
}

public class Property11
{
    public string name { get; set; }
    public Aspects564 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects564
{
}

public class Aspects565
{
}

public class Resulttype133
{
    public string name { get; set; }
    public Aspects566 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects566
{
    public string dataShape { get; set; }
}

public class Addvisibilitypermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions133 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects569 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype134 resultType { get; set; }
}

public class Parameterdefinitions133
{
    public Principal2 principal { get; set; }
    public Principaltype2 principalType { get; set; }
}

public class Principal2
{
    public string name { get; set; }
    public Aspects567 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects567
{
}

public class Principaltype2
{
    public string name { get; set; }
    public Aspects568 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects568
{
}

public class Aspects569
{
}

public class Resulttype134
{
    public string name { get; set; }
    public Aspects570 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects570
{
}

public class Removealert1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions134 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects574 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype135 resultType { get; set; }
}

public class Parameterdefinitions134
{
    public Alertname10 alertName { get; set; }
    public Property12 property { get; set; }
    public Persistent11 persistent { get; set; }
}

public class Alertname10
{
    public string name { get; set; }
    public Aspects571 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects571
{
}

public class Property12
{
    public string name { get; set; }
    public Aspects572 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects572
{
}

public class Persistent11
{
    public string name { get; set; }
    public Aspects573 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects573
{
    public bool defaultValue { get; set; }
}

public class Aspects574
{
}

public class Resulttype135
{
    public string name { get; set; }
    public Aspects575 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects575
{
}

public class Getlocationalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions135 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects579 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype136 resultType { get; set; }
}

public class Parameterdefinitions135
{
    public Alertname11 alertName { get; set; }
    public Property13 property { get; set; }
    public Parametername4 parameterName { get; set; }
}

public class Alertname11
{
    public string name { get; set; }
    public Aspects576 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects576
{
}

public class Property13
{
    public string name { get; set; }
    public Aspects577 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects577
{
}

public class Parametername4
{
    public string name { get; set; }
    public Aspects578 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects578
{
}

public class Aspects579
{
}

public class Resulttype136
{
    public string name { get; set; }
    public Aspects580 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects580
{
}

public class Getmashups1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions136 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects581 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype137 resultType { get; set; }
}

public class Parameterdefinitions136
{
}

public class Aspects581
{
}

public class Resulttype137
{
    public string name { get; set; }
    public Aspects582 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects582
{
    public string dataShape { get; set; }
}

public class Getruntimepermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions137 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects583 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype138 resultType { get; set; }
}

public class Parameterdefinitions137
{
}

public class Aspects583
{
}

public class Resulttype138
{
    public string name { get; set; }
    public Aspects584 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects584
{
}

public class Adddynamicsubscription1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions138 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects589 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype139 resultType { get; set; }
}

public class Parameterdefinitions138
{
    public Propertyname34 propertyName { get; set; }
    public Eventname3 eventName { get; set; }
    public Thingname2 thingName { get; set; }
    public Servicename3 serviceName { get; set; }
}

public class Propertyname34
{
    public string name { get; set; }
    public Aspects585 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects585
{
}

public class Eventname3
{
    public string name { get; set; }
    public Aspects586 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects586
{
}

public class Thingname2
{
    public string name { get; set; }
    public Aspects587 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects587
{
}

public class Servicename3
{
    public string name { get; set; }
    public Aspects588 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects588
{
}

public class Aspects589
{
}

public class Resulttype139
{
    public string name { get; set; }
    public Aspects590 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects590
{
}

public class Getintegeralertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions139 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects594 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype140 resultType { get; set; }
}

public class Parameterdefinitions139
{
    public Alertname12 alertName { get; set; }
    public Property14 property { get; set; }
    public Parametername5 parameterName { get; set; }
}

public class Alertname12
{
    public string name { get; set; }
    public Aspects591 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects591
{
}

public class Property14
{
    public string name { get; set; }
    public Aspects592 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects592
{
}

public class Parametername5
{
    public string name { get; set; }
    public Aspects593 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects593
{
}

public class Aspects594
{
}

public class Resulttype140
{
    public string name { get; set; }
    public Aspects595 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects595
{
}

public class Getincominglocalpropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions140 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects597 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype141 resultType { get; set; }
}

public class Parameterdefinitions140
{
    public Propertyname35 propertyName { get; set; }
}

public class Propertyname35
{
    public string name { get; set; }
    public Aspects596 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects596
{
}

public class Aspects597
{
}

public class Resulttype141
{
    public string name { get; set; }
    public Aspects598 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects598
{
    public string dataShape { get; set; }
}

public class Setvaluestream1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions141 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects600 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype142 resultType { get; set; }
}

public class Parameterdefinitions141
{
    public Name15 name { get; set; }
}

public class Name15
{
    public string name { get; set; }
    public Aspects599 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects599
{
    public string thingShape { get; set; }
}

public class Aspects600
{
}

public class Resulttype142
{
    public string name { get; set; }
    public Aspects601 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects601
{
}

public class Removeservicedefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions142 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects603 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype143 resultType { get; set; }
}

public class Parameterdefinitions142
{
    public Name16 name { get; set; }
}

public class Name16
{
    public string name { get; set; }
    public Aspects602 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects602
{
}

public class Aspects603
{
}

public class Resulttype143
{
    public string name { get; set; }
    public Aspects604 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects604
{
}

public class Getlongalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions143 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects608 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype144 resultType { get; set; }
}

public class Parameterdefinitions143
{
    public Alertname13 alertName { get; set; }
    public Property15 property { get; set; }
    public Parametername6 parameterName { get; set; }
}

public class Alertname13
{
    public string name { get; set; }
    public Aspects605 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects605
{
}

public class Property15
{
    public string name { get; set; }
    public Aspects606 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects606
{
}

public class Parametername6
{
    public string name { get; set; }
    public Aspects607 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects607
{
}

public class Aspects608
{
}

public class Resulttype144
{
    public string name { get; set; }
    public Aspects609 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects609
{
}

public class Addstringvaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions144 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects613 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype145 resultType { get; set; }
}

public class Parameterdefinitions144
{
    public Propertyname36 propertyName { get; set; }
    public Value11 value { get; set; }
    public Timestamp9 timestamp { get; set; }
}

public class Propertyname36
{
    public string name { get; set; }
    public Aspects610 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects610
{
}

public class Value11
{
    public string name { get; set; }
    public Aspects611 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects611
{
}

public class Timestamp9
{
    public string name { get; set; }
    public Aspects612 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects612
{
}

public class Aspects613
{
}

public class Resulttype145
{
    public string name { get; set; }
    public Aspects614 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects614
{
}

public class Getpropertyvalues1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions145 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects615 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype146 resultType { get; set; }
}

public class Parameterdefinitions145
{
}

public class Aspects615
{
}

public class Resulttype146
{
    public string name { get; set; }
    public Aspects616 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects616
{
}

public class Getlocalpropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions146 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects618 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype147 resultType { get; set; }
}

public class Parameterdefinitions146
{
    public Propertyname37 propertyName { get; set; }
}

public class Propertyname37
{
    public string name { get; set; }
    public Aspects617 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects617
{
}

public class Aspects618
{
}

public class Resulttype147
{
    public string name { get; set; }
    public Aspects619 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects619
{
    public string dataShape { get; set; }
}

public class Getalertsummary1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions147 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects623 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype148 resultType { get; set; }
}

public class Parameterdefinitions147
{
    public Maxitems12 maxItems { get; set; }
    public Onlyunacknowledged onlyUnacknowledged { get; set; }
    public Onlyacknowledged onlyAcknowledged { get; set; }
}

public class Maxitems12
{
    public string name { get; set; }
    public Aspects620 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects620
{
    public float defaultValue { get; set; }
}

public class Onlyunacknowledged
{
    public string name { get; set; }
    public Aspects621 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects621
{
    public bool defaultValue { get; set; }
}

public class Onlyacknowledged
{
    public string name { get; set; }
    public Aspects622 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects622
{
    public bool defaultValue { get; set; }
}

public class Aspects623
{
}

public class Resulttype148
{
    public string name { get; set; }
    public Aspects624 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects624
{
    public string dataShape { get; set; }
}

public class Queryalertsummary1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions148 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects629 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype149 resultType { get; set; }
}

public class Parameterdefinitions148
{
    public Maxitems13 maxItems { get; set; }
    public Onlyunacknowledged1 onlyUnacknowledged { get; set; }
    public Query10 query { get; set; }
    public Onlyacknowledged1 onlyAcknowledged { get; set; }
}

public class Maxitems13
{
    public string name { get; set; }
    public Aspects625 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects625
{
    public float defaultValue { get; set; }
}

public class Onlyunacknowledged1
{
    public string name { get; set; }
    public Aspects626 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects626
{
    public bool defaultValue { get; set; }
}

public class Query10
{
    public string name { get; set; }
    public Aspects627 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects627
{
}

public class Onlyacknowledged1
{
    public string name { get; set; }
    public Aspects628 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects628
{
    public bool defaultValue { get; set; }
}

public class Aspects629
{
}

public class Resulttype149
{
    public string name { get; set; }
    public Aspects630 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects630
{
    public string dataShape { get; set; }
}

public class Setlocationalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions149 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects636 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype150 resultType { get; set; }
}

public class Parameterdefinitions149
{
    public Alertname14 alertName { get; set; }
    public Property16 property { get; set; }
    public Parametername7 parameterName { get; set; }
    public Persistent12 persistent { get; set; }
    public Value12 value { get; set; }
}

public class Alertname14
{
    public string name { get; set; }
    public Aspects631 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects631
{
}

public class Property16
{
    public string name { get; set; }
    public Aspects632 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects632
{
}

public class Parametername7
{
    public string name { get; set; }
    public Aspects633 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects633
{
}

public class Persistent12
{
    public string name { get; set; }
    public Aspects634 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects634
{
    public bool defaultValue { get; set; }
}

public class Value12
{
    public string name { get; set; }
    public Aspects635 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects635
{
}

public class Aspects636
{
}

public class Resulttype150
{
    public string name { get; set; }
    public Aspects637 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects637
{
}

public class Getlongpropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions150 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects639 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype151 resultType { get; set; }
}

public class Parameterdefinitions150
{
    public Propertyname38 propertyName { get; set; }
}

public class Propertyname38
{
    public string name { get; set; }
    public Aspects638 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects638
{
}

public class Aspects639
{
}

public class Resulttype151
{
    public string name { get; set; }
    public Aspects640 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects640
{
}

public class Addpropertytransformdefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions151 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects647 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype152 resultType { get; set; }
}

public class Parameterdefinitions151
{
    public Logged1 logged { get; set; }
    public Name17 name { get; set; }
    public Description6 description { get; set; }
    public Category5 category { get; set; }
    public Propertytransformconfig propertyTransformConfig { get; set; }
    public Timeout4 timeout { get; set; }
}

public class Logged1
{
    public string name { get; set; }
    public Aspects641 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects641
{
    public bool defaultValue { get; set; }
}

public class Name17
{
    public string name { get; set; }
    public Aspects642 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects642
{
}

public class Description6
{
    public string name { get; set; }
    public Aspects643 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects643
{
    public string defaultValue { get; set; }
}

public class Category5
{
    public string name { get; set; }
    public Aspects644 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects644
{
}

public class Propertytransformconfig
{
    public string name { get; set; }
    public Aspects645 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects645
{
    public string dataShape { get; set; }
}

public class Timeout4
{
    public string name { get; set; }
    public Aspects646 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects646
{
    public int defaultValue { get; set; }
}

public class Aspects647
{
}

public class Resulttype152
{
    public string name { get; set; }
    public Aspects648 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects648
{
}

public class Geteventdefinitions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions152 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects651 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype153 resultType { get; set; }
}

public class Parameterdefinitions152
{
    public Category6 category { get; set; }
    public Datashape4 dataShape { get; set; }
}

public class Category6
{
    public string name { get; set; }
    public Aspects649 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects649
{
}

public class Datashape4
{
    public string name { get; set; }
    public Aspects650 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects650
{
}

public class Aspects651
{
}

public class Resulttype153
{
    public string name { get; set; }
    public Aspects652 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects652
{
    public string dataShape { get; set; }
}

public class Getthingtemplate1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions153 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects653 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype154 resultType { get; set; }
}

public class Parameterdefinitions153
{
}

public class Aspects653
{
}

public class Resulttype154
{
    public string name { get; set; }
    public Aspects654 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects654
{
    public string dataShape { get; set; }
}

public class Querynamedpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions154 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects661 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype155 resultType { get; set; }
}

public class Parameterdefinitions154
{
    public Oldestfirst10 oldestFirst { get; set; }
    public Maxitems14 maxItems { get; set; }
    public Enddate12 endDate { get; set; }
    public Propertynames2 propertyNames { get; set; }
    public Query11 query { get; set; }
    public Startdate12 startDate { get; set; }
}

public class Oldestfirst10
{
    public string name { get; set; }
    public Aspects655 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects655
{
}

public class Maxitems14
{
    public string name { get; set; }
    public Aspects656 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects656
{
    public float defaultValue { get; set; }
}

public class Enddate12
{
    public string name { get; set; }
    public Aspects657 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects657
{
}

public class Propertynames2
{
    public string name { get; set; }
    public Aspects658 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects658
{
    public string dataShape { get; set; }
}

public class Query11
{
    public string name { get; set; }
    public Aspects659 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects659
{
}

public class Startdate12
{
    public string name { get; set; }
    public Aspects660 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects660
{
}

public class Aspects661
{
}

public class Resulttype155
{
    public string name { get; set; }
    public Aspects662 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects662
{
}

public class Setpropertyvalues1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions155 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects664 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype156 resultType { get; set; }
}

public class Parameterdefinitions155
{
    public Values2 values { get; set; }
}

public class Values2
{
    public string name { get; set; }
    public Aspects663 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects663
{
}

public class Aspects664
{
}

public class Resulttype156
{
    public string name { get; set; }
    public Aspects665 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects665
{
}

public class Getanomalyalerttrainingstatisticsforproperty1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions156 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects667 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype157 resultType { get; set; }
}

public class Parameterdefinitions156
{
    public Property17 property { get; set; }
}

public class Property17
{
    public string name { get; set; }
    public Aspects666 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects666
{
}

public class Aspects667
{
}

public class Resulttype157
{
    public string name { get; set; }
    public Aspects668 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects668
{
    public string dataShape { get; set; }
}

public class Queryintegerpropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions157 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects675 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype158 resultType { get; set; }
}

public class Parameterdefinitions157
{
    public Oldestfirst11 oldestFirst { get; set; }
    public Maxitems15 maxItems { get; set; }
    public Enddate13 endDate { get; set; }
    public Propertyname39 propertyName { get; set; }
    public Query12 query { get; set; }
    public Startdate13 startDate { get; set; }
}

public class Oldestfirst11
{
    public string name { get; set; }
    public Aspects669 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects669
{
}

public class Maxitems15
{
    public string name { get; set; }
    public Aspects670 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects670
{
    public float defaultValue { get; set; }
}

public class Enddate13
{
    public string name { get; set; }
    public Aspects671 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects671
{
}

public class Propertyname39
{
    public string name { get; set; }
    public Aspects672 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects672
{
}

public class Query12
{
    public string name { get; set; }
    public Aspects673 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects673
{
}

public class Startdate13
{
    public string name { get; set; }
    public Aspects674 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects674
{
}

public class Aspects675
{
}

public class Resulttype158
{
    public string name { get; set; }
    public Aspects676 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects676
{
    public string dataShape { get; set; }
}

public class Disablething1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions158 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects677 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype159 resultType { get; set; }
}

public class Parameterdefinitions158
{
}

public class Aspects677
{
}

public class Resulttype159
{
    public string name { get; set; }
    public Aspects678 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects678
{
}

public class Getpropertydefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions159 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects680 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype160 resultType { get; set; }
}

public class Parameterdefinitions159
{
    public Name18 name { get; set; }
}

public class Name18
{
    public string name { get; set; }
    public Aspects679 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects679
{
}

public class Aspects680
{
}

public class Resulttype160
{
    public string name { get; set; }
    public Aspects681 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects681
{
    public string dataShape { get; set; }
}

public class Addthingcodevaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions160 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects685 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype161 resultType { get; set; }
}

public class Parameterdefinitions160
{
    public Propertyname40 propertyName { get; set; }
    public Value13 value { get; set; }
    public Timestamp10 timestamp { get; set; }
}

public class Propertyname40
{
    public string name { get; set; }
    public Aspects682 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects682
{
}

public class Value13
{
    public string name { get; set; }
    public Aspects683 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects683
{
}

public class Timestamp10
{
    public string name { get; set; }
    public Aspects684 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects684
{
}

public class Aspects685
{
}

public class Resulttype161
{
    public string name { get; set; }
    public Aspects686 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects686
{
}

public class Getalertsummaryforproperty1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions161 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects691 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype162 resultType { get; set; }
}

public class Parameterdefinitions161
{
    public Maxitems16 maxItems { get; set; }
    public Onlyunacknowledged2 onlyUnacknowledged { get; set; }
    public Property18 property { get; set; }
    public Onlyacknowledged2 onlyAcknowledged { get; set; }
}

public class Maxitems16
{
    public string name { get; set; }
    public Aspects687 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects687
{
    public float defaultValue { get; set; }
}

public class Onlyunacknowledged2
{
    public string name { get; set; }
    public Aspects688 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects688
{
    public bool defaultValue { get; set; }
}

public class Property18
{
    public string name { get; set; }
    public Aspects689 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects689
{
}

public class Onlyacknowledged2
{
    public string name { get; set; }
    public Aspects690 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects690
{
    public bool defaultValue { get; set; }
}

public class Aspects691
{
}

public class Resulttype162
{
    public string name { get; set; }
    public Aspects692 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects692
{
    public string dataShape { get; set; }
}

public class Getpropertytime1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions162 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects694 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype163 resultType { get; set; }
}

public class Parameterdefinitions162
{
    public Propertyname41 propertyName { get; set; }
}

public class Propertyname41
{
    public string name { get; set; }
    public Aspects693 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects693
{
}

public class Aspects694
{
}

public class Resulttype163
{
    public string name { get; set; }
    public Aspects695 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects695
{
}

public class Addvec2valuestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions163 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects699 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype164 resultType { get; set; }
}

public class Parameterdefinitions163
{
    public Propertyname42 propertyName { get; set; }
    public Value14 value { get; set; }
    public Timestamp11 timestamp { get; set; }
}

public class Propertyname42
{
    public string name { get; set; }
    public Aspects696 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects696
{
}

public class Value14
{
    public string name { get; set; }
    public Aspects697 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects697
{
}

public class Timestamp11
{
    public string name { get; set; }
    public Aspects698 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects698
{
}

public class Aspects699
{
}

public class Resulttype164
{
    public string name { get; set; }
    public Aspects700 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects700
{
}

public class Getincominglocalpropertybindings1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions164 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects701 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype165 resultType { get; set; }
}

public class Parameterdefinitions164
{
}

public class Aspects701
{
}

public class Resulttype165
{
    public string name { get; set; }
    public Aspects702 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects702
{
    public string dataShape { get; set; }
}

public class Getavatarurl1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions165 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects703 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype166 resultType { get; set; }
}

public class Parameterdefinitions165
{
}

public class Aspects703
{
}

public class Resulttype166
{
    public string name { get; set; }
    public Aspects704 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects704
{
}

public class Addimagevaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions166 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects708 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype167 resultType { get; set; }
}

public class Parameterdefinitions166
{
    public Propertyname43 propertyName { get; set; }
    public Value15 value { get; set; }
    public Timestamp12 timestamp { get; set; }
}

public class Propertyname43
{
    public string name { get; set; }
    public Aspects705 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects705
{
}

public class Value15
{
    public string name { get; set; }
    public Aspects706 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects706
{
}

public class Timestamp12
{
    public string name { get; set; }
    public Aspects707 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects707
{
}

public class Aspects708
{
}

public class Resulttype167
{
    public string name { get; set; }
    public Aspects709 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects709
{
}

public class Getpropertydefinitions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions167 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects713 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype168 resultType { get; set; }
}

public class Parameterdefinitions167
{
    public Category7 category { get; set; }
    public Type10 type { get; set; }
    public Datashape5 dataShape { get; set; }
}

public class Category7
{
    public string name { get; set; }
    public Aspects710 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects710
{
}

public class Type10
{
    public string name { get; set; }
    public Aspects711 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects711
{
}

public class Datashape5
{
    public string name { get; set; }
    public Aspects712 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects712
{
}

public class Aspects713
{
}

public class Resulttype168
{
    public string name { get; set; }
    public Aspects714 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects714
{
    public string dataShape { get; set; }
}

public class Getsummaryinformation1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions168 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects715 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype169 resultType { get; set; }
}

public class Parameterdefinitions168
{
}

public class Aspects715
{
}

public class Resulttype169
{
    public string name { get; set; }
    public Aspects716 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects716
{
    public string dataShape { get; set; }
}

public class Querythingcodepropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions169 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects723 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype170 resultType { get; set; }
}

public class Parameterdefinitions169
{
    public Oldestfirst12 oldestFirst { get; set; }
    public Maxitems17 maxItems { get; set; }
    public Enddate14 endDate { get; set; }
    public Propertyname44 propertyName { get; set; }
    public Query13 query { get; set; }
    public Startdate14 startDate { get; set; }
}

public class Oldestfirst12
{
    public string name { get; set; }
    public Aspects717 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects717
{
}

public class Maxitems17
{
    public string name { get; set; }
    public Aspects718 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects718
{
    public float defaultValue { get; set; }
}

public class Enddate14
{
    public string name { get; set; }
    public Aspects719 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects719
{
}

public class Propertyname44
{
    public string name { get; set; }
    public Aspects720 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects720
{
}

public class Query13
{
    public string name { get; set; }
    public Aspects721 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects721
{
}

public class Startdate14
{
    public string name { get; set; }
    public Aspects722 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects722
{
}

public class Aspects723
{
}

public class Resulttype170
{
    public string name { get; set; }
    public Aspects724 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects724
{
    public string dataShape { get; set; }
}

public class Removeremoteeventbinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions170 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects726 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype171 resultType { get; set; }
}

public class Parameterdefinitions170
{
    public Eventname4 eventName { get; set; }
}

public class Eventname4
{
    public string name { get; set; }
    public Aspects725 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects725
{
}

public class Aspects726
{
}

public class Resulttype171
{
    public string name { get; set; }
    public Aspects727 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects727
{
}

public class Getoutgoingdependenciesasnetwork1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions171 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects730 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype172 resultType { get; set; }
}

public class Parameterdefinitions171
{
    public Maxdepth1 maxDepth { get; set; }
    public Maxitems18 maxItems { get; set; }
}

public class Maxdepth1
{
    public string name { get; set; }
    public Aspects728 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects728
{
    public float defaultValue { get; set; }
}

public class Maxitems18
{
    public string name { get; set; }
    public Aspects729 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects729
{
    public float defaultValue { get; set; }
}

public class Aspects730
{
}

public class Resulttype172
{
    public string name { get; set; }
    public Aspects731 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects731
{
    public string dataShape { get; set; }
}

public class Getlocalalertdefinitions1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions172 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects733 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype173 resultType { get; set; }
}

public class Parameterdefinitions172
{
    public Property19 property { get; set; }
}

public class Property19
{
    public string name { get; set; }
    public Aspects732 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects732
{
}

public class Aspects733
{
}

public class Resulttype173
{
    public string name { get; set; }
    public Aspects734 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects734
{
    public string dataShape { get; set; }
}

public class Getalertstatusesforproperty1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions173 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects736 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype174 resultType { get; set; }
}

public class Parameterdefinitions173
{
    public Property20 property { get; set; }
}

public class Property20
{
    public string name { get; set; }
    public Aspects735 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects735
{
}

public class Aspects736
{
    public string dataShape { get; set; }
}

public class Resulttype174
{
    public string name { get; set; }
    public Aspects737 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects737
{
}

public class Getnumberalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions174 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects741 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype175 resultType { get; set; }
}

public class Parameterdefinitions174
{
    public Alertname15 alertName { get; set; }
    public Property21 property { get; set; }
    public Parametername8 parameterName { get; set; }
}

public class Alertname15
{
    public string name { get; set; }
    public Aspects738 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects738
{
}

public class Property21
{
    public string name { get; set; }
    public Aspects739 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects739
{
}

public class Parametername8
{
    public string name { get; set; }
    public Aspects740 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects740
{
}

public class Aspects741
{
}

public class Resulttype175
{
    public string name { get; set; }
    public Aspects742 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects742
{
}

public class Getallanomalyalerttrainingstatistics1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions175 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects743 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype176 resultType { get; set; }
}

public class Parameterdefinitions175
{
}

public class Aspects743
{
}

public class Resulttype176
{
    public string name { get; set; }
    public Aspects744 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects744
{
    public string dataShape { get; set; }
}

public class Getpropertyquality1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions176 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects746 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype177 resultType { get; set; }
}

public class Parameterdefinitions176
{
    public Propertyname45 propertyName { get; set; }
}

public class Propertyname45
{
    public string name { get; set; }
    public Aspects745 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects745
{
}

public class Aspects746
{
}

public class Resulttype177
{
    public string name { get; set; }
    public Aspects747 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects747
{
}

public class Getinstancemetadatawithpermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions177 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects748 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype178 resultType { get; set; }
}

public class Parameterdefinitions177
{
}

public class Aspects748
{
}

public class Resulttype178
{
    public string name { get; set; }
    public Aspects749 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects749
{
}

public class Getvisibilitypermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions178 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects750 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype179 resultType { get; set; }
}

public class Parameterdefinitions178
{
}

public class Aspects750
{
}

public class Resulttype179
{
    public string name { get; set; }
    public Aspects751 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects751
{
}

public class Getincomingdependenciesasnetwork1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions179 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects754 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype180 resultType { get; set; }
}

public class Parameterdefinitions179
{
    public Maxdepth2 maxDepth { get; set; }
    public Maxitems19 maxItems { get; set; }
}

public class Maxdepth2
{
    public string name { get; set; }
    public Aspects752 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects752
{
    public float defaultValue { get; set; }
}

public class Maxitems19
{
    public string name { get; set; }
    public Aspects753 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects753
{
    public float defaultValue { get; set; }
}

public class Aspects754
{
}

public class Resulttype180
{
    public string name { get; set; }
    public Aspects755 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects755
{
    public string dataShape { get; set; }
}

public class Hasalert1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions180 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects758 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype181 resultType { get; set; }
}

public class Parameterdefinitions180
{
    public Alertname16 alertName { get; set; }
    public Property22 property { get; set; }
}

public class Alertname16
{
    public string name { get; set; }
    public Aspects756 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects756
{
}

public class Property22
{
    public string name { get; set; }
    public Aspects757 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects757
{
}

public class Aspects758
{
}

public class Resulttype181
{
    public string name { get; set; }
    public Aspects759 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects759
{
}

public class Removeeventdefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions181 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects761 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype182 resultType { get; set; }
}

public class Parameterdefinitions181
{
    public Name19 name { get; set; }
}

public class Name19
{
    public string name { get; set; }
    public Aspects760 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects760
{
}

public class Aspects761
{
}

public class Resulttype182
{
    public string name { get; set; }
    public Aspects762 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects762
{
}

public class Setruntimepermissionsasjson1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions182 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects764 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype183 resultType { get; set; }
}

public class Parameterdefinitions182
{
    public Permissions2 permissions { get; set; }
}

public class Permissions2
{
    public string name { get; set; }
    public Aspects763 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects763
{
}

public class Aspects764
{
}

public class Resulttype183
{
    public string name { get; set; }
    public Aspects765 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects765
{
}

public class Enablesubscription1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions183 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects769 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype184 resultType { get; set; }
}

public class Parameterdefinitions183
{
    public Propertyname46 propertyName { get; set; }
    public Eventname5 eventName { get; set; }
    public Thingname3 thingName { get; set; }
}

public class Propertyname46
{
    public string name { get; set; }
    public Aspects766 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects766
{
}

public class Eventname5
{
    public string name { get; set; }
    public Aspects767 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects767
{
}

public class Thingname3
{
    public string name { get; set; }
    public Aspects768 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects768
{
}

public class Aspects769
{
}

public class Resulttype184
{
    public string name { get; set; }
    public Aspects770 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects770
{
}

public class Getlastmodifieddate1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions184 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects771 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype185 resultType { get; set; }
}

public class Parameterdefinitions184
{
}

public class Aspects771
{
}

public class Resulttype185
{
    public string name { get; set; }
    public Aspects772 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects772
{
}

public class Querydatetimepropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions185 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects779 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype186 resultType { get; set; }
}

public class Parameterdefinitions185
{
    public Oldestfirst13 oldestFirst { get; set; }
    public Maxitems20 maxItems { get; set; }
    public Enddate15 endDate { get; set; }
    public Propertyname47 propertyName { get; set; }
    public Query14 query { get; set; }
    public Startdate15 startDate { get; set; }
}

public class Oldestfirst13
{
    public string name { get; set; }
    public Aspects773 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects773
{
}

public class Maxitems20
{
    public string name { get; set; }
    public Aspects774 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects774
{
    public float defaultValue { get; set; }
}

public class Enddate15
{
    public string name { get; set; }
    public Aspects775 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects775
{
}

public class Propertyname47
{
    public string name { get; set; }
    public Aspects776 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects776
{
}

public class Query14
{
    public string name { get; set; }
    public Aspects777 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects777
{
}

public class Startdate15
{
    public string name { get; set; }
    public Aspects778 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects778
{
}

public class Aspects779
{
}

public class Resulttype186
{
    public string name { get; set; }
    public Aspects780 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects780
{
    public string dataShape { get; set; }
}

public class Setremoteeventbinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions186 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects783 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype187 resultType { get; set; }
}

public class Parameterdefinitions186
{
    public Sourceeventname sourceEventName { get; set; }
    public Eventname6 eventName { get; set; }
}

public class Sourceeventname
{
    public string name { get; set; }
    public Aspects781 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects781
{
}

public class Eventname6
{
    public string name { get; set; }
    public Aspects782 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects782
{
}

public class Aspects783
{
}

public class Resulttype187
{
    public string name { get; set; }
    public Aspects784 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects784
{
}

public class Enablealertsforproperty1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions187 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects788 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype188 resultType { get; set; }
}

public class Parameterdefinitions187
{
    public Alertname17 alertName { get; set; }
    public Property23 property { get; set; }
    public Persistent13 persistent { get; set; }
}

public class Alertname17
{
    public string name { get; set; }
    public Aspects785 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects785
{
}

public class Property23
{
    public string name { get; set; }
    public Aspects786 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects786
{
}

public class Persistent13
{
    public string name { get; set; }
    public Aspects787 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects787
{
    public bool defaultValue { get; set; }
}

public class Aspects788
{
}

public class Resulttype188
{
    public string name { get; set; }
    public Aspects789 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects789
{
}

public class Getstringalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions188 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects793 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype189 resultType { get; set; }
}

public class Parameterdefinitions188
{
    public Alertname18 alertName { get; set; }
    public Property24 property { get; set; }
    public Parametername9 parameterName { get; set; }
}

public class Alertname18
{
    public string name { get; set; }
    public Aspects790 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects790
{
}

public class Property24
{
    public string name { get; set; }
    public Aspects791 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects791
{
}

public class Parametername9
{
    public string name { get; set; }
    public Aspects792 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects792
{
}

public class Aspects793
{
}

public class Resulttype189
{
    public string name { get; set; }
    public Aspects794 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects794
{
}

public class Deleteconfigurationtablerows1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions189 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects798 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype190 resultType { get; set; }
}

public class Parameterdefinitions189
{
    public Values3 values { get; set; }
    public Persistent14 persistent { get; set; }
    public Tablename7 tableName { get; set; }
}

public class Values3
{
    public string name { get; set; }
    public Aspects795 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects795
{
}

public class Persistent14
{
    public string name { get; set; }
    public Aspects796 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects796
{
    public bool defaultValue { get; set; }
}

public class Tablename7
{
    public string name { get; set; }
    public Aspects797 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects797
{
}

public class Aspects798
{
}

public class Resulttype190
{
    public string name { get; set; }
    public Aspects799 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects799
{
}

public class Removepropertydefinition1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions190 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects801 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype191 resultType { get; set; }
}

public class Parameterdefinitions190
{
    public Name20 name { get; set; }
}

public class Name20
{
    public string name { get; set; }
    public Aspects800 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects800
{
}

public class Aspects801
{
}

public class Resulttype191
{
    public string name { get; set; }
    public Aspects802 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects802
{
}

public class Setconfigurationtablerows1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions191 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects806 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype192 resultType { get; set; }
}

public class Parameterdefinitions191
{
    public Values4 values { get; set; }
    public Persistent15 persistent { get; set; }
    public Tablename8 tableName { get; set; }
}

public class Values4
{
    public string name { get; set; }
    public Aspects803 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects803
{
}

public class Persistent15
{
    public string name { get; set; }
    public Aspects804 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects804
{
    public bool defaultValue { get; set; }
}

public class Tablename8
{
    public string name { get; set; }
    public Aspects805 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects805
{
}

public class Aspects806
{
}

public class Resulttype192
{
    public string name { get; set; }
    public Aspects807 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects807
{
}

public class Setstringalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions192 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects813 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype193 resultType { get; set; }
}

public class Parameterdefinitions192
{
    public Alertname19 alertName { get; set; }
    public Property25 property { get; set; }
    public Parametername10 parameterName { get; set; }
    public Persistent16 persistent { get; set; }
    public Value16 value { get; set; }
}

public class Alertname19
{
    public string name { get; set; }
    public Aspects808 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects808
{
}

public class Property25
{
    public string name { get; set; }
    public Aspects809 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects809
{
}

public class Parametername10
{
    public string name { get; set; }
    public Aspects810 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects810
{
}

public class Persistent16
{
    public string name { get; set; }
    public Aspects811 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects811
{
    public bool defaultValue { get; set; }
}

public class Value16
{
    public string name { get; set; }
    public Aspects812 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects812
{
}

public class Aspects813
{
}

public class Resulttype193
{
    public string name { get; set; }
    public Aspects814 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects814
{
}

public class Adddesigntimepermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions193 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects819 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype194 resultType { get; set; }
}

public class Parameterdefinitions193
{
    public Allow1 allow { get; set; }
    public Principal3 principal { get; set; }
    public Type11 type { get; set; }
    public Principaltype3 principalType { get; set; }
}

public class Allow1
{
    public string name { get; set; }
    public Aspects815 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects815
{
}

public class Principal3
{
    public string name { get; set; }
    public Aspects816 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects816
{
}

public class Type11
{
    public string name { get; set; }
    public Aspects817 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects817
{
}

public class Principaltype3
{
    public string name { get; set; }
    public Aspects818 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects818
{
}

public class Aspects819
{
}

public class Resulttype194
{
    public string name { get; set; }
    public Aspects820 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects820
{
}

public class Checkpermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions194 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects823 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype195 resultType { get; set; }
}

public class Parameterdefinitions194
{
    public Name21 name { get; set; }
    public Type12 type { get; set; }
}

public class Name21
{
    public string name { get; set; }
    public Aspects821 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects821
{
}

public class Type12
{
    public string name { get; set; }
    public Aspects822 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects822
{
}

public class Aspects823
{
}

public class Resulttype195
{
    public string name { get; set; }
    public Aspects824 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects824
{
}

public class Setdatetimealertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions195 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects830 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype196 resultType { get; set; }
}

public class Parameterdefinitions195
{
    public Alertname20 alertName { get; set; }
    public Property26 property { get; set; }
    public Parametername11 parameterName { get; set; }
    public Persistent17 persistent { get; set; }
    public Value17 value { get; set; }
}

public class Alertname20
{
    public string name { get; set; }
    public Aspects825 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects825
{
}

public class Property26
{
    public string name { get; set; }
    public Aspects826 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects826
{
}

public class Parametername11
{
    public string name { get; set; }
    public Aspects827 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects827
{
}

public class Persistent17
{
    public string name { get; set; }
    public Aspects828 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects828
{
    public bool defaultValue { get; set; }
}

public class Value17
{
    public string name { get; set; }
    public Aspects829 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects829
{
}

public class Aspects830
{
}

public class Resulttype196
{
    public string name { get; set; }
    public Aspects831 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects831
{
}

public class Getbooleanalertparameter1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions196 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects835 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype197 resultType { get; set; }
}

public class Parameterdefinitions196
{
    public Alertname21 alertName { get; set; }
    public Property27 property { get; set; }
    public Parametername12 parameterName { get; set; }
}

public class Alertname21
{
    public string name { get; set; }
    public Aspects832 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects832
{
}

public class Property27
{
    public string name { get; set; }
    public Aspects833 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects833
{
}

public class Parametername12
{
    public string name { get; set; }
    public Aspects834 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects834
{
}

public class Aspects835
{
}

public class Resulttype197
{
    public string name { get; set; }
    public Aspects836 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects836
{
}

public class Geteffectivelocalpropertybindings1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions197 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects837 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype198 resultType { get; set; }
}

public class Parameterdefinitions197
{
}

public class Aspects837
{
}

public class Resulttype198
{
    public string name { get; set; }
    public Aspects838 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects838
{
    public string dataShape { get; set; }
}

public class Getdescription1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions198 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects839 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype199 resultType { get; set; }
}

public class Parameterdefinitions198
{
}

public class Aspects839
{
}

public class Resulttype199
{
    public string name { get; set; }
    public Aspects840 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects840
{
}

public class Disableallalerts1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions199 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects842 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype200 resultType { get; set; }
}

public class Parameterdefinitions199
{
    public Persistent18 persistent { get; set; }
}

public class Persistent18
{
    public string name { get; set; }
    public Aspects841 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects841
{
    public bool defaultValue { get; set; }
}

public class Aspects842
{
}

public class Resulttype200
{
    public string name { get; set; }
    public Aspects843 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects843
{
}

public class Getlocationpropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions200 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects845 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype201 resultType { get; set; }
}

public class Parameterdefinitions200
{
    public Propertyname48 propertyName { get; set; }
}

public class Propertyname48
{
    public string name { get; set; }
    public Aspects844 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects844
{
}

public class Aspects845
{
}

public class Resulttype201
{
    public string name { get; set; }
    public Aspects846 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects846
{
}

public class Getnamedpropertyvaluesvtq1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions201 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects848 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype202 resultType { get; set; }
}

public class Parameterdefinitions201
{
    public Propertynames3 propertyNames { get; set; }
}

public class Propertynames3
{
    public string name { get; set; }
    public Aspects847 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects847
{
    public string dataShape { get; set; }
}

public class Aspects848
{
}

public class Resulttype202
{
    public string name { get; set; }
    public Aspects849 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects849
{
    public string isMultiRow { get; set; }
}

public class Hasincomingdependencies1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions202 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects850 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype203 resultType { get; set; }
}

public class Parameterdefinitions202
{
}

public class Aspects850
{
}

public class Resulttype203
{
    public string name { get; set; }
    public Aspects851 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects851
{
}

public class Getnamedpropertyvaluesvtqa1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions203 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects853 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype204 resultType { get; set; }
}

public class Parameterdefinitions203
{
    public Propertynames4 propertyNames { get; set; }
}

public class Propertynames4
{
    public string name { get; set; }
    public Aspects852 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects852
{
    public string dataShape { get; set; }
}

public class Aspects853
{
}

public class Resulttype204
{
    public string name { get; set; }
    public Aspects854 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects854
{
    public string isMultiRow { get; set; }
}

public class Addinfotablevaluestreamentry1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions204 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects858 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype205 resultType { get; set; }
}

public class Parameterdefinitions204
{
    public Propertyname49 propertyName { get; set; }
    public Value18 value { get; set; }
    public Timestamp13 timestamp { get; set; }
}

public class Propertyname49
{
    public string name { get; set; }
    public Aspects855 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects855
{
}

public class Value18
{
    public string name { get; set; }
    public Aspects856 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects856
{
}

public class Timestamp13
{
    public string name { get; set; }
    public Aspects857 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects857
{
}

public class Aspects858
{
}

public class Resulttype205
{
    public string name { get; set; }
    public Aspects859 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects859
{
}

public class Getvec4propertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions205 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects861 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype206 resultType { get; set; }
}

public class Parameterdefinitions205
{
    public Propertyname50 propertyName { get; set; }
}

public class Propertyname50
{
    public string name { get; set; }
    public Aspects860 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects860
{
}

public class Aspects861
{
}

public class Resulttype206
{
    public string name { get; set; }
    public Aspects862 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects862
{
}

public class Setavatar1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions206 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects864 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype207 resultType { get; set; }
}

public class Parameterdefinitions206
{
    public Content content { get; set; }
}

public class Content
{
    public string name { get; set; }
    public Aspects863 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects863
{
}

public class Aspects864
{
}

public class Resulttype207
{
    public string name { get; set; }
    public Aspects865 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects865
{
}

public class Queryinfotablepropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions207 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects873 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype208 resultType { get; set; }
}

public class Parameterdefinitions207
{
    public Flatten flatten { get; set; }
    public Oldestfirst14 oldestFirst { get; set; }
    public Maxitems21 maxItems { get; set; }
    public Enddate16 endDate { get; set; }
    public Propertyname51 propertyName { get; set; }
    public Query15 query { get; set; }
    public Startdate16 startDate { get; set; }
}

public class Flatten
{
    public string name { get; set; }
    public Aspects866 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects866
{
    public bool defaultValue { get; set; }
}

public class Oldestfirst14
{
    public string name { get; set; }
    public Aspects867 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects867
{
}

public class Maxitems21
{
    public string name { get; set; }
    public Aspects868 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects868
{
    public float defaultValue { get; set; }
}

public class Enddate16
{
    public string name { get; set; }
    public Aspects869 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects869
{
}

public class Propertyname51
{
    public string name { get; set; }
    public Aspects870 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects870
{
}

public class Query15
{
    public string name { get; set; }
    public Aspects871 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects871
{
}

public class Startdate16
{
    public string name { get; set; }
    public Aspects872 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects872
{
}

public class Aspects873
{
}

public class Resulttype208
{
    public string name { get; set; }
    public Aspects874 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects874
{
    public string dataShape { get; set; }
}

public class Setprojectname1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions208 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects876 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype209 resultType { get; set; }
}

public class Parameterdefinitions208
{
    public Projectname projectName { get; set; }
}

public class Projectname
{
    public string name { get; set; }
    public Aspects875 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects875
{
}

public class Aspects876
{
}

public class Resulttype209
{
    public string name { get; set; }
    public Aspects877 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects877
{
}

public class Retrainalert1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions209 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects880 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype210 resultType { get; set; }
}

public class Parameterdefinitions209
{
    public Alertname22 alertName { get; set; }
    public Propertyname52 propertyName { get; set; }
}

public class Alertname22
{
    public string name { get; set; }
    public Aspects878 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects878
{
}

public class Propertyname52
{
    public string name { get; set; }
    public Aspects879 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects879
{
}

public class Aspects880
{
}

public class Resulttype210
{
    public string name { get; set; }
    public Aspects881 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects881
{
}

public class Getpropertylogging1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions210 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects883 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype211 resultType { get; set; }
}

public class Parameterdefinitions210
{
    public Propertyname53 propertyName { get; set; }
}

public class Propertyname53
{
    public string name { get; set; }
    public Aspects882 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects882
{
}

public class Aspects883
{
}

public class Resulttype211
{
    public string name { get; set; }
    public Aspects884 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects884
{
}

public class Queryvec3propertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions211 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects891 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype212 resultType { get; set; }
}

public class Parameterdefinitions211
{
    public Oldestfirst15 oldestFirst { get; set; }
    public Maxitems22 maxItems { get; set; }
    public Enddate17 endDate { get; set; }
    public Propertyname54 propertyName { get; set; }
    public Query16 query { get; set; }
    public Startdate17 startDate { get; set; }
}

public class Oldestfirst15
{
    public string name { get; set; }
    public Aspects885 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects885
{
}

public class Maxitems22
{
    public string name { get; set; }
    public Aspects886 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects886
{
    public float defaultValue { get; set; }
}

public class Enddate17
{
    public string name { get; set; }
    public Aspects887 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects887
{
}

public class Propertyname54
{
    public string name { get; set; }
    public Aspects888 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects888
{
}

public class Query16
{
    public string name { get; set; }
    public Aspects889 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects889
{
}

public class Startdate17
{
    public string name { get; set; }
    public Aspects890 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects890
{
}

public class Aspects891
{
}

public class Resulttype212
{
    public string name { get; set; }
    public Aspects892 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects892
{
    public string dataShape { get; set; }
}

public class Setdescription1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions212 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects894 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype213 resultType { get; set; }
}

public class Parameterdefinitions212
{
    public Description7 description { get; set; }
}

public class Description7
{
    public string name { get; set; }
    public Aspects893 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects893
{
}

public class Aspects894
{
}

public class Resulttype213
{
    public string name { get; set; }
    public Aspects895 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects895
{
}

public class Getconfigurationtable1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions213 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects897 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype214 resultType { get; set; }
}

public class Parameterdefinitions213
{
    public Tablename9 tableName { get; set; }
}

public class Tablename9
{
    public string name { get; set; }
    public Aspects896 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects896
{
}

public class Aspects897
{
}

public class Resulttype214
{
    public string name { get; set; }
    public Aspects898 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects898
{
}

public class Deletedesigntimepermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions214 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects902 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype215 resultType { get; set; }
}

public class Parameterdefinitions214
{
    public Principal4 principal { get; set; }
    public Type13 type { get; set; }
    public Principaltype4 principalType { get; set; }
}

public class Principal4
{
    public string name { get; set; }
    public Aspects899 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects899
{
}

public class Type13
{
    public string name { get; set; }
    public Aspects900 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects900
{
}

public class Principaltype4
{
    public string name { get; set; }
    public Aspects901 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects901
{
}

public class Aspects902
{
}

public class Resulttype215
{
    public string name { get; set; }
    public Aspects903 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects903
{
}

public class Getremoteservicebinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions215 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects905 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype216 resultType { get; set; }
}

public class Parameterdefinitions215
{
    public Servicename4 serviceName { get; set; }
}

public class Servicename4
{
    public string name { get; set; }
    public Aspects904 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects904
{
}

public class Aspects905
{
}

public class Resulttype216
{
    public string name { get; set; }
    public Aspects906 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects906
{
    public string dataShape { get; set; }
}

public class Purgepropertyhistory1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions216 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects911 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype217 resultType { get; set; }
}

public class Parameterdefinitions216
{
    public Enddate18 endDate { get; set; }
    public Immediate immediate { get; set; }
    public Propertyname55 propertyName { get; set; }
    public Startdate18 startDate { get; set; }
}

public class Enddate18
{
    public string name { get; set; }
    public Aspects907 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects907
{
}

public class Immediate
{
    public string name { get; set; }
    public Aspects908 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects908
{
    public bool defaultValue { get; set; }
}

public class Propertyname55
{
    public string name { get; set; }
    public Aspects909 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects909
{
}

public class Startdate18
{
    public string name { get; set; }
    public Aspects910 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects910
{
}

public class Aspects911
{
}

public class Resulttype217
{
    public string name { get; set; }
    public Aspects912 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects912
{
}

public class Deletevisibilitypermission1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions217 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects915 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype218 resultType { get; set; }
}

public class Parameterdefinitions217
{
    public Principal5 principal { get; set; }
    public Principaltype5 principalType { get; set; }
}

public class Principal5
{
    public string name { get; set; }
    public Aspects913 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects913
{
}

public class Principaltype5
{
    public string name { get; set; }
    public Aspects914 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects914
{
}

public class Aspects915
{
}

public class Resulttype218
{
    public string name { get; set; }
    public Aspects916 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects916
{
}

public class Getpropertyvaluesvtqa1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions218 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects917 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype219 resultType { get; set; }
}

public class Parameterdefinitions218
{
}

public class Aspects917
{
}

public class Resulttype219
{
    public string name { get; set; }
    public Aspects918 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects918
{
    public string isMultiRow { get; set; }
}

public class Getintegerpropertyvalue1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions219 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects920 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype220 resultType { get; set; }
}

public class Parameterdefinitions219
{
    public Propertyname56 propertyName { get; set; }
}

public class Propertyname56
{
    public string name { get; set; }
    public Aspects919 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects919
{
}

public class Aspects920
{
}

public class Resulttype220
{
    public string name { get; set; }
    public Aspects921 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects921
{
}

public class Geteffectivelocalpropertybinding1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions220 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects923 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype221 resultType { get; set; }
}

public class Parameterdefinitions220
{
    public Propertyname57 propertyName { get; set; }
}

public class Propertyname57
{
    public string name { get; set; }
    public Aspects922 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects922
{
}

public class Aspects923
{
}

public class Resulttype221
{
    public string name { get; set; }
    public Aspects924 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects924
{
    public string dataShape { get; set; }
}

public class Getpropertyvaluesasmultirowtable1
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions221 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects925 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype222 resultType { get; set; }
}

public class Parameterdefinitions221
{
}

public class Aspects925
{
}

public class Resulttype222
{
    public string name { get; set; }
    public Aspects926 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects926
{
}

public class Effectiveremoteeventbindings
{
}

public class Implementedshapes
{
}

public class Effectiveremotepropertybindings
{
}

public class Effectiveimplementedshapes
{
}

public class Effectiveremoteservicebindings
{
}

public class Configurationtables228
{
}

public class Owner
{
    public string name { get; set; }
    public string type { get; set; }
}

public class Visibilitypermissions
{
    public object[] Visibility { get; set; }
}

public class Effectivelocalpropertybindings
{
}

public class Remoteeventbindings
{
}

public class Remotepropertybindings
{
}

public class Thingshape
{
    public Propertydefinitions1 propertyDefinitions { get; set; }
    public Subscriptions1 subscriptions { get; set; }
    public Eventdefinitions1 eventDefinitions { get; set; }
    public Serviceimplementations1 serviceImplementations { get; set; }
    public Servicemappings1 serviceMappings { get; set; }
    public Servicedefinitions1 serviceDefinitions { get; set; }
}

public class Propertydefinitions1
{
    public Led11 led1 { get; set; }
    public Led21 led2 { get; set; }
    public Led31 led3 { get; set; }
    public Led41 led4 { get; set; }
}

public class Led11
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects927 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects927
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Led21
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects928 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects928
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Led31
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects929 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects929
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Led41
{
    public string sourceType { get; set; }
    public string name { get; set; }
    public Aspects930 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects930
{
    public string dataChangeType { get; set; }
    public float cacheTime { get; set; }
}

public class Subscriptions1
{
}

public class Eventdefinitions1
{
}

public class Serviceimplementations1
{
    public Ioservice2 ioservice { get; set; }
}

public class Ioservice2
{
    public string name { get; set; }
    public string description { get; set; }
    public string handlerName { get; set; }
    public Configurationtables229 configurationTables { get; set; }
}

public class Configurationtables229
{
    public Script1 Script { get; set; }
}

public class Script1
{
    public bool isMultiRow { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public Row1[] rows { get; set; }
    public int ordinal { get; set; }
    public Datashape6 dataShape { get; set; }
}

public class Datashape6
{
    public Fielddefinitions1 fieldDefinitions { get; set; }
}

public class Fielddefinitions1
{
    public Code1 code { get; set; }
}

public class Code1
{
    public string name { get; set; }
    public Aspects931 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects931
{
}

public class Row1
{
    public string code { get; set; }
}

public class Servicemappings1
{
}

public class Servicedefinitions1
{
    public Ioservice3 ioservice { get; set; }
}

public class Ioservice3
{
    public bool isAllowOverride { get; set; }
    public bool isOpen { get; set; }
    public string sourceType { get; set; }
    public Parameterdefinitions222 parameterDefinitions { get; set; }
    public string name { get; set; }
    public Aspects932 aspects { get; set; }
    public bool isLocalOnly { get; set; }
    public string description { get; set; }
    public bool isPrivate { get; set; }
    public string sourceName { get; set; }
    public string category { get; set; }
    public Resulttype223 resultType { get; set; }
}

public class Parameterdefinitions222
{
}

public class Aspects932
{
    public bool isAsync { get; set; }
}

public class Resulttype223
{
    public string name { get; set; }
    public Aspects933 aspects { get; set; }
    public string description { get; set; }
    public string baseType { get; set; }
    public int ordinal { get; set; }
}

public class Aspects933
{
}

public class Runtimepermissions
{
    public object[] permissions { get; set; }
}

public class Propertybindings
{
}

public class Alertconfigurations
{
    public object[] led1 { get; set; }
    public object[] led2 { get; set; }
    public object[] led3 { get; set; }
    public object[] led4 { get; set; }
}

public class Configurationtabledefinitions
{
}

public class Thingproperties
{
}

namespace robo
{
    class ThingJson
    {
    }
}
