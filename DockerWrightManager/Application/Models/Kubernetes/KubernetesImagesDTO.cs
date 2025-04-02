using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models.Kubernetes.Images
{

    public class KubernetesImagesDTO
    {
        public string kind { get; set; }
        public string apiVersion { get; set; }
        public Metadata metadata { get; set; }
        public Item[] items { get; set; }
    }

    public class Metadata
    {
        public string resourceVersion { get; set; }
    }

    public class Item
    {
        public Metadata1 metadata { get; set; }
        public Spec spec { get; set; }
        public Status status { get; set; }
    }

    public class Metadata1
    {
        public string name { get; set; }
        public string generateName { get; set; }
        public string _namespace { get; set; }
        public string uid { get; set; }
        public string resourceVersion { get; set; }
        public DateTime creationTimestamp { get; set; }
        public Labels labels { get; set; }
        public Ownerreference[] ownerReferences { get; set; }
        public Managedfield[] managedFields { get; set; }
        public Annotations annotations { get; set; }
    }

    public class Labels
    {
        public string k8sapp { get; set; }
        public string podtemplatehash { get; set; }
        public string component { get; set; }
        public string tier { get; set; }
        public string controllerrevisionhash { get; set; }
        public string podtemplategeneration { get; set; }
        public string addonmanagerkubernetesiomode { get; set; }
        public string integrationtest { get; set; }
    }

    public class Annotations
    {
        public string kubeadmkubernetesioetcdadvertiseclienturls { get; set; }
        public string kubernetesioconfighash { get; set; }
        public string kubernetesioconfigmirror { get; set; }
        public string kubernetesioconfigseen { get; set; }
        public string kubernetesioconfigsource { get; set; }
        public string kubeadmkubernetesiokubeapiserveradvertiseaddressendpoint { get; set; }
        public string kubectlkubernetesiolastappliedconfiguration { get; set; }
    }

    public class Ownerreference
    {
        public string apiVersion { get; set; }
        public string kind { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
        public bool controller { get; set; }
        public bool blockOwnerDeletion { get; set; }
    }

    public class Managedfield
    {
        public string manager { get; set; }
        public string operation { get; set; }
        public string apiVersion { get; set; }
        public DateTime time { get; set; }
        public string fieldsType { get; set; }
        public Fieldsv1 fieldsV1 { get; set; }
    }

    public class Fieldsv1
    {
        public FMetadata fmetadata { get; set; }
        public FSpec fspec { get; set; }
        public FStatus fstatus { get; set; }
    }

    public class FMetadata
    {
        public FGeneratename fgenerateName { get; set; }
        public FLabels flabels { get; set; }
        public FOwnerreferences fownerReferences { get; set; }
        public FAnnotations fannotations { get; set; }
    }

    public class FGeneratename
    {
    }

    public class FLabels
    {
        public _ _ { get; set; }
        public FK8sApp fk8sapp { get; set; }
        public FPodTemplateHash fpodtemplatehash { get; set; }
        public FComponent fcomponent { get; set; }
        public FTier ftier { get; set; }
        public FControllerRevisionHash fcontrollerrevisionhash { get; set; }
        public FPodTemplateGeneration fpodtemplategeneration { get; set; }
        public FAddonmanagerKubernetesIoMode faddonmanagerkubernetesiomode { get; set; }
        public FIntegrationTest fintegrationtest { get; set; }
    }

    public class _
    {
    }

    public class FK8sApp
    {
    }

    public class FPodTemplateHash
    {
    }

    public class FComponent
    {
    }

    public class FTier
    {
    }

    public class FControllerRevisionHash
    {
    }

    public class FPodTemplateGeneration
    {
    }

    public class FAddonmanagerKubernetesIoMode
    {
    }

    public class FIntegrationTest
    {
    }

    public class FOwnerreferences
    {
        public _1 _ { get; set; }
        public KUidF3b29cefA5d74DdbB32cF572fcf72cdc kuidf3b29cefa5d74ddbb32cf572fcf72cdc { get; set; }
        public KUid34Cf398910934256A0e7C0d73887dbfc kuid34cf398910934256a0e7c0d73887dbfc { get; set; }
        public KUid38Db194a86B5483397A316Ffd6ae7b5b kuid38db194a86b5483397a316ffd6ae7b5b { get; set; }
        public KUid4Cfb5ba388D94EacB7dd74213A7fed78 kuid4cfb5ba388d94eacb7dd74213a7fed78 { get; set; }
    }

    public class _1
    {
    }

    public class KUidF3b29cefA5d74DdbB32cF572fcf72cdc
    {
        public _2 _ { get; set; }
        public FApiversion fapiVersion { get; set; }
        public FBlockownerdeletion fblockOwnerDeletion { get; set; }
        public FController fcontroller { get; set; }
        public FKind fkind { get; set; }
        public FName fname { get; set; }
        public FUid fuid { get; set; }
    }

    public class _2
    {
    }

    public class FApiversion
    {
    }

    public class FBlockownerdeletion
    {
    }

    public class FController
    {
    }

    public class FKind
    {
    }

    public class FName
    {
    }

    public class FUid
    {
    }

    public class KUid34Cf398910934256A0e7C0d73887dbfc
    {
        public _3 _ { get; set; }
        public FApiversion1 fapiVersion { get; set; }
        public FController1 fcontroller { get; set; }
        public FKind1 fkind { get; set; }
        public FName1 fname { get; set; }
        public FUid1 fuid { get; set; }
    }

    public class _3
    {
    }

    public class FApiversion1
    {
    }

    public class FController1
    {
    }

    public class FKind1
    {
    }

    public class FName1
    {
    }

    public class FUid1
    {
    }

    public class KUid38Db194a86B5483397A316Ffd6ae7b5b
    {
        public _4 _ { get; set; }
        public FApiversion2 fapiVersion { get; set; }
        public FBlockownerdeletion1 fblockOwnerDeletion { get; set; }
        public FController2 fcontroller { get; set; }
        public FKind2 fkind { get; set; }
        public FName2 fname { get; set; }
        public FUid2 fuid { get; set; }
    }

    public class _4
    {
    }

    public class FApiversion2
    {
    }

    public class FBlockownerdeletion1
    {
    }

    public class FController2
    {
    }

    public class FKind2
    {
    }

    public class FName2
    {
    }

    public class FUid2
    {
    }

    public class KUid4Cfb5ba388D94EacB7dd74213A7fed78
    {
        public _5 _ { get; set; }
        public FApiversion3 fapiVersion { get; set; }
        public FBlockownerdeletion2 fblockOwnerDeletion { get; set; }
        public FController3 fcontroller { get; set; }
        public FKind3 fkind { get; set; }
        public FName3 fname { get; set; }
        public FUid3 fuid { get; set; }
    }

    public class _5
    {
    }

    public class FApiversion3
    {
    }

    public class FBlockownerdeletion2
    {
    }

    public class FController3
    {
    }

    public class FKind3
    {
    }

    public class FName3
    {
    }

    public class FUid3
    {
    }

    public class FAnnotations
    {
        public _6 _ { get; set; }
        public FKubeadmKubernetesIoEtcdAdvertiseClientUrls fkubeadmkubernetesioetcdadvertiseclienturls { get; set; }
        public FKubernetesIoConfigHash fkubernetesioconfighash { get; set; }
        public FKubernetesIoConfigMirror fkubernetesioconfigmirror { get; set; }
        public FKubernetesIoConfigSeen fkubernetesioconfigseen { get; set; }
        public FKubernetesIoConfigSource fkubernetesioconfigsource { get; set; }
        public FKubeadmKubernetesIoKubeApiserverAdvertiseAddressEndpoint fkubeadmkubernetesiokubeapiserveradvertiseaddressendpoint { get; set; }
        public FKubectlKubernetesIoLastAppliedConfiguration fkubectlkubernetesiolastappliedconfiguration { get; set; }
    }

    public class _6
    {
    }

    public class FKubeadmKubernetesIoEtcdAdvertiseClientUrls
    {
    }

    public class FKubernetesIoConfigHash
    {
    }

    public class FKubernetesIoConfigMirror
    {
    }

    public class FKubernetesIoConfigSeen
    {
    }

    public class FKubernetesIoConfigSource
    {
    }

    public class FKubeadmKubernetesIoKubeApiserverAdvertiseAddressEndpoint
    {
    }

    public class FKubectlKubernetesIoLastAppliedConfiguration
    {
    }

    public class FSpec
    {
        public FContainers fcontainers { get; set; }
        public FDnspolicy fdnsPolicy { get; set; }
        public FEnableservicelinks fenableServiceLinks { get; set; }
        public FNodeselector fnodeSelector { get; set; }
        public FPriorityclassname fpriorityClassName { get; set; }
        public FRestartpolicy frestartPolicy { get; set; }
        public FSchedulername fschedulerName { get; set; }
        public FSecuritycontext2 fsecurityContext { get; set; }
        public FServiceaccount fserviceAccount { get; set; }
        public FServiceaccountname fserviceAccountName { get; set; }
        public FTerminationgraceperiodseconds fterminationGracePeriodSeconds { get; set; }
        public FTolerations ftolerations { get; set; }
        public FVolumes fvolumes { get; set; }
        public FHostnetwork fhostNetwork { get; set; }
        public FNodename fnodeName { get; set; }
        public FAffinity faffinity { get; set; }
    }

    public class FContainers
    {
        public KNameCoredns knamecoredns { get; set; }
        public KNameEtcd knameetcd { get; set; }
        public KNameKubeApiserver knamekubeapiserver { get; set; }
        public KNameKubeControllerManager knamekubecontrollermanager { get; set; }
        public KNameKubeProxy knamekubeproxy { get; set; }
        public KNameKubeScheduler knamekubescheduler { get; set; }
        public KNameMetricsServer knamemetricsserver { get; set; }
        public KNameStorageProvisioner knamestorageprovisioner { get; set; }
    }

    public class KNameCoredns
    {
        public _7 _ { get; set; }
        public FArgs fargs { get; set; }
        public FImage fimage { get; set; }
        public FImagepullpolicy fimagePullPolicy { get; set; }
        public FLivenessprobe flivenessProbe { get; set; }
        public FName4 fname { get; set; }
        public FPorts fports { get; set; }
        public FReadinessprobe freadinessProbe { get; set; }
        public FResources fresources { get; set; }
        public FSecuritycontext fsecurityContext { get; set; }
        public FTerminationmessagepath fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy fterminationMessagePolicy { get; set; }
        public FVolumemounts fvolumeMounts { get; set; }
    }

    public class _7
    {
    }

    public class FArgs
    {
    }

    public class FImage
    {
    }

    public class FImagepullpolicy
    {
    }

    public class FLivenessprobe
    {
        public _8 _ { get; set; }
        public FFailurethreshold ffailureThreshold { get; set; }
        public FHttpget fhttpGet { get; set; }
        public FInitialdelayseconds finitialDelaySeconds { get; set; }
        public FPeriodseconds fperiodSeconds { get; set; }
        public FSuccessthreshold fsuccessThreshold { get; set; }
        public FTimeoutseconds ftimeoutSeconds { get; set; }
    }

    public class _8
    {
    }

    public class FFailurethreshold
    {
    }

    public class FHttpget
    {
        public _9 _ { get; set; }
        public FPath fpath { get; set; }
        public FPort fport { get; set; }
        public FScheme fscheme { get; set; }
    }

    public class _9
    {
    }

    public class FPath
    {
    }

    public class FPort
    {
    }

    public class FScheme
    {
    }

    public class FInitialdelayseconds
    {
    }

    public class FPeriodseconds
    {
    }

    public class FSuccessthreshold
    {
    }

    public class FTimeoutseconds
    {
    }

    public class FName4
    {
    }

    public class FPorts
    {
        public _10 _ { get; set; }
        public KContainerport53ProtocolTCP kcontainerPort53protocolTCP { get; set; }
        public KContainerport53ProtocolUDP kcontainerPort53protocolUDP { get; set; }
        public KContainerport9153ProtocolTCP kcontainerPort9153protocolTCP { get; set; }
    }

    public class _10
    {
    }

    public class KContainerport53ProtocolTCP
    {
        public _11 _ { get; set; }
        public FContainerport fcontainerPort { get; set; }
        public FName5 fname { get; set; }
        public FProtocol fprotocol { get; set; }
    }

    public class _11
    {
    }

    public class FContainerport
    {
    }

    public class FName5
    {
    }

    public class FProtocol
    {
    }

    public class KContainerport53ProtocolUDP
    {
        public _12 _ { get; set; }
        public FContainerport1 fcontainerPort { get; set; }
        public FName6 fname { get; set; }
        public FProtocol1 fprotocol { get; set; }
    }

    public class _12
    {
    }

    public class FContainerport1
    {
    }

    public class FName6
    {
    }

    public class FProtocol1
    {
    }

    public class KContainerport9153ProtocolTCP
    {
        public _13 _ { get; set; }
        public FContainerport2 fcontainerPort { get; set; }
        public FName7 fname { get; set; }
        public FProtocol2 fprotocol { get; set; }
    }

    public class _13
    {
    }

    public class FContainerport2
    {
    }

    public class FName7
    {
    }

    public class FProtocol2
    {
    }

    public class FReadinessprobe
    {
        public _14 _ { get; set; }
        public FFailurethreshold1 ffailureThreshold { get; set; }
        public FHttpget1 fhttpGet { get; set; }
        public FPeriodseconds1 fperiodSeconds { get; set; }
        public FSuccessthreshold1 fsuccessThreshold { get; set; }
        public FTimeoutseconds1 ftimeoutSeconds { get; set; }
    }

    public class _14
    {
    }

    public class FFailurethreshold1
    {
    }

    public class FHttpget1
    {
        public _15 _ { get; set; }
        public FPath1 fpath { get; set; }
        public FPort1 fport { get; set; }
        public FScheme1 fscheme { get; set; }
    }

    public class _15
    {
    }

    public class FPath1
    {
    }

    public class FPort1
    {
    }

    public class FScheme1
    {
    }

    public class FPeriodseconds1
    {
    }

    public class FSuccessthreshold1
    {
    }

    public class FTimeoutseconds1
    {
    }

    public class FResources
    {
        public _16 _ { get; set; }
        public FLimits flimits { get; set; }
        public FRequests frequests { get; set; }
    }

    public class _16
    {
    }

    public class FLimits
    {
        public _17 _ { get; set; }
        public FMemory fmemory { get; set; }
    }

    public class _17
    {
    }

    public class FMemory
    {
    }

    public class FRequests
    {
        public _18 _ { get; set; }
        public FCpu fcpu { get; set; }
        public FMemory1 fmemory { get; set; }
    }

    public class _18
    {
    }

    public class FCpu
    {
    }

    public class FMemory1
    {
    }

    public class FSecuritycontext
    {
        public _19 _ { get; set; }
        public FAllowprivilegeescalation fallowPrivilegeEscalation { get; set; }
        public FCapabilities fcapabilities { get; set; }
        public FReadonlyrootfilesystem freadOnlyRootFilesystem { get; set; }
    }

    public class _19
    {
    }

    public class FAllowprivilegeescalation
    {
    }

    public class FCapabilities
    {
        public _20 _ { get; set; }
        public FAdd fadd { get; set; }
        public FDrop fdrop { get; set; }
    }

    public class _20
    {
    }

    public class FAdd
    {
    }

    public class FDrop
    {
    }

    public class FReadonlyrootfilesystem
    {
    }

    public class FTerminationmessagepath
    {
    }

    public class FTerminationmessagepolicy
    {
    }

    public class FVolumemounts
    {
        public _21 _ { get; set; }
        public KMountpathEtcCoredns kmountPathetccoredns { get; set; }
    }

    public class _21
    {
    }

    public class KMountpathEtcCoredns
    {
        public _22 _ { get; set; }
        public FMountpath fmountPath { get; set; }
        public FName8 fname { get; set; }
        public FReadonly freadOnly { get; set; }
    }

    public class _22
    {
    }

    public class FMountpath
    {
    }

    public class FName8
    {
    }

    public class FReadonly
    {
    }

    public class KNameEtcd
    {
        public _23 _ { get; set; }
        public FCommand fcommand { get; set; }
        public FImage1 fimage { get; set; }
        public FImagepullpolicy1 fimagePullPolicy { get; set; }
        public FLivenessprobe1 flivenessProbe { get; set; }
        public FName9 fname { get; set; }
        public FResources1 fresources { get; set; }
        public FStartupprobe fstartupProbe { get; set; }
        public FTerminationmessagepath1 fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy1 fterminationMessagePolicy { get; set; }
        public FVolumemounts1 fvolumeMounts { get; set; }
    }

    public class _23
    {
    }

    public class FCommand
    {
    }

    public class FImage1
    {
    }

    public class FImagepullpolicy1
    {
    }

    public class FLivenessprobe1
    {
        public _24 _ { get; set; }
        public FFailurethreshold2 ffailureThreshold { get; set; }
        public FHttpget2 fhttpGet { get; set; }
        public FInitialdelayseconds1 finitialDelaySeconds { get; set; }
        public FPeriodseconds2 fperiodSeconds { get; set; }
        public FSuccessthreshold2 fsuccessThreshold { get; set; }
        public FTimeoutseconds2 ftimeoutSeconds { get; set; }
    }

    public class _24
    {
    }

    public class FFailurethreshold2
    {
    }

    public class FHttpget2
    {
        public _25 _ { get; set; }
        public FHost fhost { get; set; }
        public FPath2 fpath { get; set; }
        public FPort2 fport { get; set; }
        public FScheme2 fscheme { get; set; }
    }

    public class _25
    {
    }

    public class FHost
    {
    }

    public class FPath2
    {
    }

    public class FPort2
    {
    }

    public class FScheme2
    {
    }

    public class FInitialdelayseconds1
    {
    }

    public class FPeriodseconds2
    {
    }

    public class FSuccessthreshold2
    {
    }

    public class FTimeoutseconds2
    {
    }

    public class FName9
    {
    }

    public class FResources1
    {
        public _26 _ { get; set; }
        public FRequests1 frequests { get; set; }
    }

    public class _26
    {
    }

    public class FRequests1
    {
        public _27 _ { get; set; }
        public FCpu1 fcpu { get; set; }
        public FEphemeralStorage fephemeralstorage { get; set; }
        public FMemory2 fmemory { get; set; }
    }

    public class _27
    {
    }

    public class FCpu1
    {
    }

    public class FEphemeralStorage
    {
    }

    public class FMemory2
    {
    }

    public class FStartupprobe
    {
        public _28 _ { get; set; }
        public FFailurethreshold3 ffailureThreshold { get; set; }
        public FHttpget3 fhttpGet { get; set; }
        public FInitialdelayseconds2 finitialDelaySeconds { get; set; }
        public FPeriodseconds3 fperiodSeconds { get; set; }
        public FSuccessthreshold3 fsuccessThreshold { get; set; }
        public FTimeoutseconds3 ftimeoutSeconds { get; set; }
    }

    public class _28
    {
    }

    public class FFailurethreshold3
    {
    }

    public class FHttpget3
    {
        public _29 _ { get; set; }
        public FHost1 fhost { get; set; }
        public FPath3 fpath { get; set; }
        public FPort3 fport { get; set; }
        public FScheme3 fscheme { get; set; }
    }

    public class _29
    {
    }

    public class FHost1
    {
    }

    public class FPath3
    {
    }

    public class FPort3
    {
    }

    public class FScheme3
    {
    }

    public class FInitialdelayseconds2
    {
    }

    public class FPeriodseconds3
    {
    }

    public class FSuccessthreshold3
    {
    }

    public class FTimeoutseconds3
    {
    }

    public class FTerminationmessagepath1
    {
    }

    public class FTerminationmessagepolicy1
    {
    }

    public class FVolumemounts1
    {
        public _30 _ { get; set; }
        public KMountpathVarLibMinikubeCertsEtcd kmountPathvarlibminikubecertsetcd { get; set; }
        public KMountpathVarLibMinikubeEtcd kmountPathvarlibminikubeetcd { get; set; }
    }

    public class _30
    {
    }

    public class KMountpathVarLibMinikubeCertsEtcd
    {
        public _31 _ { get; set; }
        public FMountpath1 fmountPath { get; set; }
        public FName10 fname { get; set; }
    }

    public class _31
    {
    }

    public class FMountpath1
    {
    }

    public class FName10
    {
    }

    public class KMountpathVarLibMinikubeEtcd
    {
        public _32 _ { get; set; }
        public FMountpath2 fmountPath { get; set; }
        public FName11 fname { get; set; }
    }

    public class _32
    {
    }

    public class FMountpath2
    {
    }

    public class FName11
    {
    }

    public class KNameKubeApiserver
    {
        public _33 _ { get; set; }
        public FCommand1 fcommand { get; set; }
        public FImage2 fimage { get; set; }
        public FImagepullpolicy2 fimagePullPolicy { get; set; }
        public FLivenessprobe2 flivenessProbe { get; set; }
        public FName12 fname { get; set; }
        public FReadinessprobe1 freadinessProbe { get; set; }
        public FResources2 fresources { get; set; }
        public FStartupprobe1 fstartupProbe { get; set; }
        public FTerminationmessagepath2 fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy2 fterminationMessagePolicy { get; set; }
        public FVolumemounts2 fvolumeMounts { get; set; }
    }

    public class _33
    {
    }

    public class FCommand1
    {
    }

    public class FImage2
    {
    }

    public class FImagepullpolicy2
    {
    }

    public class FLivenessprobe2
    {
        public _34 _ { get; set; }
        public FFailurethreshold4 ffailureThreshold { get; set; }
        public FHttpget4 fhttpGet { get; set; }
        public FInitialdelayseconds3 finitialDelaySeconds { get; set; }
        public FPeriodseconds4 fperiodSeconds { get; set; }
        public FSuccessthreshold4 fsuccessThreshold { get; set; }
        public FTimeoutseconds4 ftimeoutSeconds { get; set; }
    }

    public class _34
    {
    }

    public class FFailurethreshold4
    {
    }

    public class FHttpget4
    {
        public _35 _ { get; set; }
        public FHost2 fhost { get; set; }
        public FPath4 fpath { get; set; }
        public FPort4 fport { get; set; }
        public FScheme4 fscheme { get; set; }
    }

    public class _35
    {
    }

    public class FHost2
    {
    }

    public class FPath4
    {
    }

    public class FPort4
    {
    }

    public class FScheme4
    {
    }

    public class FInitialdelayseconds3
    {
    }

    public class FPeriodseconds4
    {
    }

    public class FSuccessthreshold4
    {
    }

    public class FTimeoutseconds4
    {
    }

    public class FName12
    {
    }

    public class FReadinessprobe1
    {
        public _36 _ { get; set; }
        public FFailurethreshold5 ffailureThreshold { get; set; }
        public FHttpget5 fhttpGet { get; set; }
        public FPeriodseconds5 fperiodSeconds { get; set; }
        public FSuccessthreshold5 fsuccessThreshold { get; set; }
        public FTimeoutseconds5 ftimeoutSeconds { get; set; }
    }

    public class _36
    {
    }

    public class FFailurethreshold5
    {
    }

    public class FHttpget5
    {
        public _37 _ { get; set; }
        public FHost3 fhost { get; set; }
        public FPath5 fpath { get; set; }
        public FPort5 fport { get; set; }
        public FScheme5 fscheme { get; set; }
    }

    public class _37
    {
    }

    public class FHost3
    {
    }

    public class FPath5
    {
    }

    public class FPort5
    {
    }

    public class FScheme5
    {
    }

    public class FPeriodseconds5
    {
    }

    public class FSuccessthreshold5
    {
    }

    public class FTimeoutseconds5
    {
    }

    public class FResources2
    {
        public _38 _ { get; set; }
        public FRequests2 frequests { get; set; }
    }

    public class _38
    {
    }

    public class FRequests2
    {
        public _39 _ { get; set; }
        public FCpu2 fcpu { get; set; }
    }

    public class _39
    {
    }

    public class FCpu2
    {
    }

    public class FStartupprobe1
    {
        public _40 _ { get; set; }
        public FFailurethreshold6 ffailureThreshold { get; set; }
        public FHttpget6 fhttpGet { get; set; }
        public FInitialdelayseconds4 finitialDelaySeconds { get; set; }
        public FPeriodseconds6 fperiodSeconds { get; set; }
        public FSuccessthreshold6 fsuccessThreshold { get; set; }
        public FTimeoutseconds6 ftimeoutSeconds { get; set; }
    }

    public class _40
    {
    }

    public class FFailurethreshold6
    {
    }

    public class FHttpget6
    {
        public _41 _ { get; set; }
        public FHost4 fhost { get; set; }
        public FPath6 fpath { get; set; }
        public FPort6 fport { get; set; }
        public FScheme6 fscheme { get; set; }
    }

    public class _41
    {
    }

    public class FHost4
    {
    }

    public class FPath6
    {
    }

    public class FPort6
    {
    }

    public class FScheme6
    {
    }

    public class FInitialdelayseconds4
    {
    }

    public class FPeriodseconds6
    {
    }

    public class FSuccessthreshold6
    {
    }

    public class FTimeoutseconds6
    {
    }

    public class FTerminationmessagepath2
    {
    }

    public class FTerminationmessagepolicy2
    {
    }

    public class FVolumemounts2
    {
        public _42 _ { get; set; }
        public KMountpathEtcCaCertificates kmountPathetccacertificates { get; set; }
        public KMountpathEtcSslCerts kmountPathetcsslcerts { get; set; }
        public KMountpathUsrLocalShareCaCertificates kmountPathusrlocalsharecacertificates { get; set; }
        public KMountpathUsrShareCaCertificates kmountPathusrsharecacertificates { get; set; }
        public KMountpathVarLibMinikubeCerts kmountPathvarlibminikubecerts { get; set; }
    }

    public class _42
    {
    }

    public class KMountpathEtcCaCertificates
    {
        public _43 _ { get; set; }
        public FMountpath3 fmountPath { get; set; }
        public FName13 fname { get; set; }
        public FReadonly1 freadOnly { get; set; }
    }

    public class _43
    {
    }

    public class FMountpath3
    {
    }

    public class FName13
    {
    }

    public class FReadonly1
    {
    }

    public class KMountpathEtcSslCerts
    {
        public _44 _ { get; set; }
        public FMountpath4 fmountPath { get; set; }
        public FName14 fname { get; set; }
        public FReadonly2 freadOnly { get; set; }
    }

    public class _44
    {
    }

    public class FMountpath4
    {
    }

    public class FName14
    {
    }

    public class FReadonly2
    {
    }

    public class KMountpathUsrLocalShareCaCertificates
    {
        public _45 _ { get; set; }
        public FMountpath5 fmountPath { get; set; }
        public FName15 fname { get; set; }
        public FReadonly3 freadOnly { get; set; }
    }

    public class _45
    {
    }

    public class FMountpath5
    {
    }

    public class FName15
    {
    }

    public class FReadonly3
    {
    }

    public class KMountpathUsrShareCaCertificates
    {
        public _46 _ { get; set; }
        public FMountpath6 fmountPath { get; set; }
        public FName16 fname { get; set; }
        public FReadonly4 freadOnly { get; set; }
    }

    public class _46
    {
    }

    public class FMountpath6
    {
    }

    public class FName16
    {
    }

    public class FReadonly4
    {
    }

    public class KMountpathVarLibMinikubeCerts
    {
        public _47 _ { get; set; }
        public FMountpath7 fmountPath { get; set; }
        public FName17 fname { get; set; }
        public FReadonly5 freadOnly { get; set; }
    }

    public class _47
    {
    }

    public class FMountpath7
    {
    }

    public class FName17
    {
    }

    public class FReadonly5
    {
    }

    public class KNameKubeControllerManager
    {
        public _48 _ { get; set; }
        public FCommand2 fcommand { get; set; }
        public FImage3 fimage { get; set; }
        public FImagepullpolicy3 fimagePullPolicy { get; set; }
        public FLivenessprobe3 flivenessProbe { get; set; }
        public FName18 fname { get; set; }
        public FResources3 fresources { get; set; }
        public FStartupprobe2 fstartupProbe { get; set; }
        public FTerminationmessagepath3 fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy3 fterminationMessagePolicy { get; set; }
        public FVolumemounts3 fvolumeMounts { get; set; }
    }

    public class _48
    {
    }

    public class FCommand2
    {
    }

    public class FImage3
    {
    }

    public class FImagepullpolicy3
    {
    }

    public class FLivenessprobe3
    {
        public _49 _ { get; set; }
        public FFailurethreshold7 ffailureThreshold { get; set; }
        public FHttpget7 fhttpGet { get; set; }
        public FInitialdelayseconds5 finitialDelaySeconds { get; set; }
        public FPeriodseconds7 fperiodSeconds { get; set; }
        public FSuccessthreshold7 fsuccessThreshold { get; set; }
        public FTimeoutseconds7 ftimeoutSeconds { get; set; }
    }

    public class _49
    {
    }

    public class FFailurethreshold7
    {
    }

    public class FHttpget7
    {
        public _50 _ { get; set; }
        public FHost5 fhost { get; set; }
        public FPath7 fpath { get; set; }
        public FPort7 fport { get; set; }
        public FScheme7 fscheme { get; set; }
    }

    public class _50
    {
    }

    public class FHost5
    {
    }

    public class FPath7
    {
    }

    public class FPort7
    {
    }

    public class FScheme7
    {
    }

    public class FInitialdelayseconds5
    {
    }

    public class FPeriodseconds7
    {
    }

    public class FSuccessthreshold7
    {
    }

    public class FTimeoutseconds7
    {
    }

    public class FName18
    {
    }

    public class FResources3
    {
        public _51 _ { get; set; }
        public FRequests3 frequests { get; set; }
    }

    public class _51
    {
    }

    public class FRequests3
    {
        public _52 _ { get; set; }
        public FCpu3 fcpu { get; set; }
    }

    public class _52
    {
    }

    public class FCpu3
    {
    }

    public class FStartupprobe2
    {
        public _53 _ { get; set; }
        public FFailurethreshold8 ffailureThreshold { get; set; }
        public FHttpget8 fhttpGet { get; set; }
        public FInitialdelayseconds6 finitialDelaySeconds { get; set; }
        public FPeriodseconds8 fperiodSeconds { get; set; }
        public FSuccessthreshold8 fsuccessThreshold { get; set; }
        public FTimeoutseconds8 ftimeoutSeconds { get; set; }
    }

    public class _53
    {
    }

    public class FFailurethreshold8
    {
    }

    public class FHttpget8
    {
        public _54 _ { get; set; }
        public FHost6 fhost { get; set; }
        public FPath8 fpath { get; set; }
        public FPort8 fport { get; set; }
        public FScheme8 fscheme { get; set; }
    }

    public class _54
    {
    }

    public class FHost6
    {
    }

    public class FPath8
    {
    }

    public class FPort8
    {
    }

    public class FScheme8
    {
    }

    public class FInitialdelayseconds6
    {
    }

    public class FPeriodseconds8
    {
    }

    public class FSuccessthreshold8
    {
    }

    public class FTimeoutseconds8
    {
    }

    public class FTerminationmessagepath3
    {
    }

    public class FTerminationmessagepolicy3
    {
    }

    public class FVolumemounts3
    {
        public _55 _ { get; set; }
        public KMountpathEtcCaCertificates1 kmountPathetccacertificates { get; set; }
        public KMountpathEtcKubernetesControllerManagerConf kmountPathetckubernetescontrollermanagerconf { get; set; }
        public KMountpathEtcSslCerts1 kmountPathetcsslcerts { get; set; }
        public KMountpathUsrLibexecKubernetesKubeletPluginsVolumeExec kmountPathusrlibexeckuberneteskubeletpluginsvolumeexec { get; set; }
        public KMountpathUsrLocalShareCaCertificates1 kmountPathusrlocalsharecacertificates { get; set; }
        public KMountpathUsrShareCaCertificates1 kmountPathusrsharecacertificates { get; set; }
        public KMountpathVarLibMinikubeCerts1 kmountPathvarlibminikubecerts { get; set; }
    }

    public class _55
    {
    }

    public class KMountpathEtcCaCertificates1
    {
        public _56 _ { get; set; }
        public FMountpath8 fmountPath { get; set; }
        public FName19 fname { get; set; }
        public FReadonly6 freadOnly { get; set; }
    }

    public class _56
    {
    }

    public class FMountpath8
    {
    }

    public class FName19
    {
    }

    public class FReadonly6
    {
    }

    public class KMountpathEtcKubernetesControllerManagerConf
    {
        public _57 _ { get; set; }
        public FMountpath9 fmountPath { get; set; }
        public FName20 fname { get; set; }
        public FReadonly7 freadOnly { get; set; }
    }

    public class _57
    {
    }

    public class FMountpath9
    {
    }

    public class FName20
    {
    }

    public class FReadonly7
    {
    }

    public class KMountpathEtcSslCerts1
    {
        public _58 _ { get; set; }
        public FMountpath10 fmountPath { get; set; }
        public FName21 fname { get; set; }
        public FReadonly8 freadOnly { get; set; }
    }

    public class _58
    {
    }

    public class FMountpath10
    {
    }

    public class FName21
    {
    }

    public class FReadonly8
    {
    }

    public class KMountpathUsrLibexecKubernetesKubeletPluginsVolumeExec
    {
        public _59 _ { get; set; }
        public FMountpath11 fmountPath { get; set; }
        public FName22 fname { get; set; }
    }

    public class _59
    {
    }

    public class FMountpath11
    {
    }

    public class FName22
    {
    }

    public class KMountpathUsrLocalShareCaCertificates1
    {
        public _60 _ { get; set; }
        public FMountpath12 fmountPath { get; set; }
        public FName23 fname { get; set; }
        public FReadonly9 freadOnly { get; set; }
    }

    public class _60
    {
    }

    public class FMountpath12
    {
    }

    public class FName23
    {
    }

    public class FReadonly9
    {
    }

    public class KMountpathUsrShareCaCertificates1
    {
        public _61 _ { get; set; }
        public FMountpath13 fmountPath { get; set; }
        public FName24 fname { get; set; }
        public FReadonly10 freadOnly { get; set; }
    }

    public class _61
    {
    }

    public class FMountpath13
    {
    }

    public class FName24
    {
    }

    public class FReadonly10
    {
    }

    public class KMountpathVarLibMinikubeCerts1
    {
        public _62 _ { get; set; }
        public FMountpath14 fmountPath { get; set; }
        public FName25 fname { get; set; }
        public FReadonly11 freadOnly { get; set; }
    }

    public class _62
    {
    }

    public class FMountpath14
    {
    }

    public class FName25
    {
    }

    public class FReadonly11
    {
    }

    public class KNameKubeProxy
    {
        public _63 _ { get; set; }
        public FCommand3 fcommand { get; set; }
        public FEnv fenv { get; set; }
        public FImage4 fimage { get; set; }
        public FImagepullpolicy4 fimagePullPolicy { get; set; }
        public FName27 fname { get; set; }
        public FResources4 fresources { get; set; }
        public FSecuritycontext1 fsecurityContext { get; set; }
        public FTerminationmessagepath4 fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy4 fterminationMessagePolicy { get; set; }
        public FVolumemounts4 fvolumeMounts { get; set; }
    }

    public class _63
    {
    }

    public class FCommand3
    {
    }

    public class FEnv
    {
        public _64 _ { get; set; }
        public KNameNODE_NAME knameNODE_NAME { get; set; }
    }

    public class _64
    {
    }

    public class KNameNODE_NAME
    {
        public _65 _ { get; set; }
        public FName26 fname { get; set; }
        public FValuefrom fvalueFrom { get; set; }
    }

    public class _65
    {
    }

    public class FName26
    {
    }

    public class FValuefrom
    {
        public _66 _ { get; set; }
        public FFieldref ffieldRef { get; set; }
    }

    public class _66
    {
    }

    public class FFieldref
    {
        public _67 _ { get; set; }
        public FApiversion4 fapiVersion { get; set; }
        public FFieldpath ffieldPath { get; set; }
    }

    public class _67
    {
    }

    public class FApiversion4
    {
    }

    public class FFieldpath
    {
    }

    public class FImage4
    {
    }

    public class FImagepullpolicy4
    {
    }

    public class FName27
    {
    }

    public class FResources4
    {
    }

    public class FSecuritycontext1
    {
        public _68 _ { get; set; }
        public FPrivileged fprivileged { get; set; }
    }

    public class _68
    {
    }

    public class FPrivileged
    {
    }

    public class FTerminationmessagepath4
    {
    }

    public class FTerminationmessagepolicy4
    {
    }

    public class FVolumemounts4
    {
        public _69 _ { get; set; }
        public KMountpathLibModules kmountPathlibmodules { get; set; }
        public KMountpathRunXtablesLock kmountPathrunxtableslock { get; set; }
        public KMountpathVarLibKubeProxy kmountPathvarlibkubeproxy { get; set; }
    }

    public class _69
    {
    }

    public class KMountpathLibModules
    {
        public _70 _ { get; set; }
        public FMountpath15 fmountPath { get; set; }
        public FName28 fname { get; set; }
        public FReadonly12 freadOnly { get; set; }
    }

    public class _70
    {
    }

    public class FMountpath15
    {
    }

    public class FName28
    {
    }

    public class FReadonly12
    {
    }

    public class KMountpathRunXtablesLock
    {
        public _71 _ { get; set; }
        public FMountpath16 fmountPath { get; set; }
        public FName29 fname { get; set; }
    }

    public class _71
    {
    }

    public class FMountpath16
    {
    }

    public class FName29
    {
    }

    public class KMountpathVarLibKubeProxy
    {
        public _72 _ { get; set; }
        public FMountpath17 fmountPath { get; set; }
        public FName30 fname { get; set; }
    }

    public class _72
    {
    }

    public class FMountpath17
    {
    }

    public class FName30
    {
    }

    public class KNameKubeScheduler
    {
        public _73 _ { get; set; }
        public FCommand4 fcommand { get; set; }
        public FImage5 fimage { get; set; }
        public FImagepullpolicy5 fimagePullPolicy { get; set; }
        public FLivenessprobe4 flivenessProbe { get; set; }
        public FName31 fname { get; set; }
        public FResources5 fresources { get; set; }
        public FStartupprobe3 fstartupProbe { get; set; }
        public FTerminationmessagepath5 fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy5 fterminationMessagePolicy { get; set; }
        public FVolumemounts5 fvolumeMounts { get; set; }
    }

    public class _73
    {
    }

    public class FCommand4
    {
    }

    public class FImage5
    {
    }

    public class FImagepullpolicy5
    {
    }

    public class FLivenessprobe4
    {
        public _74 _ { get; set; }
        public FFailurethreshold9 ffailureThreshold { get; set; }
        public FHttpget9 fhttpGet { get; set; }
        public FInitialdelayseconds7 finitialDelaySeconds { get; set; }
        public FPeriodseconds9 fperiodSeconds { get; set; }
        public FSuccessthreshold9 fsuccessThreshold { get; set; }
        public FTimeoutseconds9 ftimeoutSeconds { get; set; }
    }

    public class _74
    {
    }

    public class FFailurethreshold9
    {
    }

    public class FHttpget9
    {
        public _75 _ { get; set; }
        public FHost7 fhost { get; set; }
        public FPath9 fpath { get; set; }
        public FPort9 fport { get; set; }
        public FScheme9 fscheme { get; set; }
    }

    public class _75
    {
    }

    public class FHost7
    {
    }

    public class FPath9
    {
    }

    public class FPort9
    {
    }

    public class FScheme9
    {
    }

    public class FInitialdelayseconds7
    {
    }

    public class FPeriodseconds9
    {
    }

    public class FSuccessthreshold9
    {
    }

    public class FTimeoutseconds9
    {
    }

    public class FName31
    {
    }

    public class FResources5
    {
        public _76 _ { get; set; }
        public FRequests4 frequests { get; set; }
    }

    public class _76
    {
    }

    public class FRequests4
    {
        public _77 _ { get; set; }
        public FCpu4 fcpu { get; set; }
    }

    public class _77
    {
    }

    public class FCpu4
    {
    }

    public class FStartupprobe3
    {
        public _78 _ { get; set; }
        public FFailurethreshold10 ffailureThreshold { get; set; }
        public FHttpget10 fhttpGet { get; set; }
        public FInitialdelayseconds8 finitialDelaySeconds { get; set; }
        public FPeriodseconds10 fperiodSeconds { get; set; }
        public FSuccessthreshold10 fsuccessThreshold { get; set; }
        public FTimeoutseconds10 ftimeoutSeconds { get; set; }
    }

    public class _78
    {
    }

    public class FFailurethreshold10
    {
    }

    public class FHttpget10
    {
        public _79 _ { get; set; }
        public FHost8 fhost { get; set; }
        public FPath10 fpath { get; set; }
        public FPort10 fport { get; set; }
        public FScheme10 fscheme { get; set; }
    }

    public class _79
    {
    }

    public class FHost8
    {
    }

    public class FPath10
    {
    }

    public class FPort10
    {
    }

    public class FScheme10
    {
    }

    public class FInitialdelayseconds8
    {
    }

    public class FPeriodseconds10
    {
    }

    public class FSuccessthreshold10
    {
    }

    public class FTimeoutseconds10
    {
    }

    public class FTerminationmessagepath5
    {
    }

    public class FTerminationmessagepolicy5
    {
    }

    public class FVolumemounts5
    {
        public _80 _ { get; set; }
        public KMountpathEtcKubernetesSchedulerConf kmountPathetckubernetesschedulerconf { get; set; }
    }

    public class _80
    {
    }

    public class KMountpathEtcKubernetesSchedulerConf
    {
        public _81 _ { get; set; }
        public FMountpath18 fmountPath { get; set; }
        public FName32 fname { get; set; }
        public FReadonly13 freadOnly { get; set; }
    }

    public class _81
    {
    }

    public class FMountpath18
    {
    }

    public class FName32
    {
    }

    public class FReadonly13
    {
    }

    public class KNameMetricsServer
    {
        public _82 _ { get; set; }
        public FCommand5 fcommand { get; set; }
        public FImage6 fimage { get; set; }
        public FImagepullpolicy6 fimagePullPolicy { get; set; }
        public FName33 fname { get; set; }
        public FResources6 fresources { get; set; }
        public FTerminationmessagepath6 fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy6 fterminationMessagePolicy { get; set; }
    }

    public class _82
    {
    }

    public class FCommand5
    {
    }

    public class FImage6
    {
    }

    public class FImagepullpolicy6
    {
    }

    public class FName33
    {
    }

    public class FResources6
    {
    }

    public class FTerminationmessagepath6
    {
    }

    public class FTerminationmessagepolicy6
    {
    }

    public class KNameStorageProvisioner
    {
        public _83 _ { get; set; }
        public FCommand6 fcommand { get; set; }
        public FImage7 fimage { get; set; }
        public FImagepullpolicy7 fimagePullPolicy { get; set; }
        public FName34 fname { get; set; }
        public FResources7 fresources { get; set; }
        public FTerminationmessagepath7 fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy7 fterminationMessagePolicy { get; set; }
        public FVolumemounts6 fvolumeMounts { get; set; }
    }

    public class _83
    {
    }

    public class FCommand6
    {
    }

    public class FImage7
    {
    }

    public class FImagepullpolicy7
    {
    }

    public class FName34
    {
    }

    public class FResources7
    {
    }

    public class FTerminationmessagepath7
    {
    }

    public class FTerminationmessagepolicy7
    {
    }

    public class FVolumemounts6
    {
        public _84 _ { get; set; }
        public KMountpathTmp kmountPathtmp { get; set; }
    }

    public class _84
    {
    }

    public class KMountpathTmp
    {
        public _85 _ { get; set; }
        public FMountpath19 fmountPath { get; set; }
        public FName35 fname { get; set; }
    }

    public class _85
    {
    }

    public class FMountpath19
    {
    }

    public class FName35
    {
    }

    public class FDnspolicy
    {
    }

    public class FEnableservicelinks
    {
    }

    public class FNodeselector
    {
        public _86 _ { get; set; }
        public FKubernetesIoOs fkubernetesioos { get; set; }
    }

    public class _86
    {
    }

    public class FKubernetesIoOs
    {
    }

    public class FPriorityclassname
    {
    }

    public class FRestartpolicy
    {
    }

    public class FSchedulername
    {
    }

    public class FSecuritycontext2
    {
    }

    public class FServiceaccount
    {
    }

    public class FServiceaccountname
    {
    }

    public class FTerminationgraceperiodseconds
    {
    }

    public class FTolerations
    {
    }

    public class FVolumes
    {
        public _87 _ { get; set; }
        public KNameConfigVolume knameconfigvolume { get; set; }
        public KNameEtcdCerts knameetcdcerts { get; set; }
        public KNameEtcdData knameetcddata { get; set; }
        public KNameCaCerts knamecacerts { get; set; }
        public KNameEtcCaCertificates knameetccacertificates { get; set; }
        public KNameK8sCerts knamek8scerts { get; set; }
        public KNameUsrLocalShareCaCertificates knameusrlocalsharecacertificates { get; set; }
        public KNameUsrShareCaCertificates knameusrsharecacertificates { get; set; }
        public KNameFlexvolumeDir knameflexvolumedir { get; set; }
        public KNameKubeconfig knamekubeconfig { get; set; }
        public KNameKubeProxy1 knamekubeproxy { get; set; }
        public KNameLibModules knamelibmodules { get; set; }
        public KNameXtablesLock knamextableslock { get; set; }
        public KNameTmp knametmp { get; set; }
    }

    public class _87
    {
    }

    public class KNameConfigVolume
    {
        public _88 _ { get; set; }
        public FConfigmap fconfigMap { get; set; }
        public FName37 fname { get; set; }
    }

    public class _88
    {
    }

    public class FConfigmap
    {
        public _89 _ { get; set; }
        public FDefaultmode fdefaultMode { get; set; }
        public FItems fitems { get; set; }
        public FName36 fname { get; set; }
    }

    public class _89
    {
    }

    public class FDefaultmode
    {
    }

    public class FItems
    {
    }

    public class FName36
    {
    }

    public class FName37
    {
    }

    public class KNameEtcdCerts
    {
        public _90 _ { get; set; }
        public FHostpath fhostPath { get; set; }
        public FName38 fname { get; set; }
    }

    public class _90
    {
    }

    public class FHostpath
    {
        public _91 _ { get; set; }
        public FPath11 fpath { get; set; }
        public FType ftype { get; set; }
    }

    public class _91
    {
    }

    public class FPath11
    {
    }

    public class FType
    {
    }

    public class FName38
    {
    }

    public class KNameEtcdData
    {
        public _92 _ { get; set; }
        public FHostpath1 fhostPath { get; set; }
        public FName39 fname { get; set; }
    }

    public class _92
    {
    }

    public class FHostpath1
    {
        public _93 _ { get; set; }
        public FPath12 fpath { get; set; }
        public FType1 ftype { get; set; }
    }

    public class _93
    {
    }

    public class FPath12
    {
    }

    public class FType1
    {
    }

    public class FName39
    {
    }

    public class KNameCaCerts
    {
        public _94 _ { get; set; }
        public FHostpath2 fhostPath { get; set; }
        public FName40 fname { get; set; }
    }

    public class _94
    {
    }

    public class FHostpath2
    {
        public _95 _ { get; set; }
        public FPath13 fpath { get; set; }
        public FType2 ftype { get; set; }
    }

    public class _95
    {
    }

    public class FPath13
    {
    }

    public class FType2
    {
    }

    public class FName40
    {
    }

    public class KNameEtcCaCertificates
    {
        public _96 _ { get; set; }
        public FHostpath3 fhostPath { get; set; }
        public FName41 fname { get; set; }
    }

    public class _96
    {
    }

    public class FHostpath3
    {
        public _97 _ { get; set; }
        public FPath14 fpath { get; set; }
        public FType3 ftype { get; set; }
    }

    public class _97
    {
    }

    public class FPath14
    {
    }

    public class FType3
    {
    }

    public class FName41
    {
    }

    public class KNameK8sCerts
    {
        public _98 _ { get; set; }
        public FHostpath4 fhostPath { get; set; }
        public FName42 fname { get; set; }
    }

    public class _98
    {
    }

    public class FHostpath4
    {
        public _99 _ { get; set; }
        public FPath15 fpath { get; set; }
        public FType4 ftype { get; set; }
    }

    public class _99
    {
    }

    public class FPath15
    {
    }

    public class FType4
    {
    }

    public class FName42
    {
    }

    public class KNameUsrLocalShareCaCertificates
    {
        public _100 _ { get; set; }
        public FHostpath5 fhostPath { get; set; }
        public FName43 fname { get; set; }
    }

    public class _100
    {
    }

    public class FHostpath5
    {
        public _101 _ { get; set; }
        public FPath16 fpath { get; set; }
        public FType5 ftype { get; set; }
    }

    public class _101
    {
    }

    public class FPath16
    {
    }

    public class FType5
    {
    }

    public class FName43
    {
    }

    public class KNameUsrShareCaCertificates
    {
        public _102 _ { get; set; }
        public FHostpath6 fhostPath { get; set; }
        public FName44 fname { get; set; }
    }

    public class _102
    {
    }

    public class FHostpath6
    {
        public _103 _ { get; set; }
        public FPath17 fpath { get; set; }
        public FType6 ftype { get; set; }
    }

    public class _103
    {
    }

    public class FPath17
    {
    }

    public class FType6
    {
    }

    public class FName44
    {
    }

    public class KNameFlexvolumeDir
    {
        public _104 _ { get; set; }
        public FHostpath7 fhostPath { get; set; }
        public FName45 fname { get; set; }
    }

    public class _104
    {
    }

    public class FHostpath7
    {
        public _105 _ { get; set; }
        public FPath18 fpath { get; set; }
        public FType7 ftype { get; set; }
    }

    public class _105
    {
    }

    public class FPath18
    {
    }

    public class FType7
    {
    }

    public class FName45
    {
    }

    public class KNameKubeconfig
    {
        public _106 _ { get; set; }
        public FHostpath8 fhostPath { get; set; }
        public FName46 fname { get; set; }
    }

    public class _106
    {
    }

    public class FHostpath8
    {
        public _107 _ { get; set; }
        public FPath19 fpath { get; set; }
        public FType8 ftype { get; set; }
    }

    public class _107
    {
    }

    public class FPath19
    {
    }

    public class FType8
    {
    }

    public class FName46
    {
    }

    public class KNameKubeProxy1
    {
        public _108 _ { get; set; }
        public FConfigmap1 fconfigMap { get; set; }
        public FName48 fname { get; set; }
    }

    public class _108
    {
    }

    public class FConfigmap1
    {
        public _109 _ { get; set; }
        public FDefaultmode1 fdefaultMode { get; set; }
        public FName47 fname { get; set; }
    }

    public class _109
    {
    }

    public class FDefaultmode1
    {
    }

    public class FName47
    {
    }

    public class FName48
    {
    }

    public class KNameLibModules
    {
        public _110 _ { get; set; }
        public FHostpath9 fhostPath { get; set; }
        public FName49 fname { get; set; }
    }

    public class _110
    {
    }

    public class FHostpath9
    {
        public _111 _ { get; set; }
        public FPath20 fpath { get; set; }
        public FType9 ftype { get; set; }
    }

    public class _111
    {
    }

    public class FPath20
    {
    }

    public class FType9
    {
    }

    public class FName49
    {
    }

    public class KNameXtablesLock
    {
        public _112 _ { get; set; }
        public FHostpath10 fhostPath { get; set; }
        public FName50 fname { get; set; }
    }

    public class _112
    {
    }

    public class FHostpath10
    {
        public _113 _ { get; set; }
        public FPath21 fpath { get; set; }
        public FType10 ftype { get; set; }
    }

    public class _113
    {
    }

    public class FPath21
    {
    }

    public class FType10
    {
    }

    public class FName50
    {
    }

    public class KNameTmp
    {
        public _114 _ { get; set; }
        public FHostpath11 fhostPath { get; set; }
        public FName51 fname { get; set; }
    }

    public class _114
    {
    }

    public class FHostpath11
    {
        public _115 _ { get; set; }
        public FPath22 fpath { get; set; }
        public FType11 ftype { get; set; }
    }

    public class _115
    {
    }

    public class FPath22
    {
    }

    public class FType11
    {
    }

    public class FName51
    {
    }

    public class FHostnetwork
    {
    }

    public class FNodename
    {
    }

    public class FAffinity
    {
        public _116 _ { get; set; }
        public FNodeaffinity fnodeAffinity { get; set; }
    }

    public class _116
    {
    }

    public class FNodeaffinity
    {
        public _117 _ { get; set; }
        public FRequiredduringschedulingignoredduringexecution frequiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }

    public class _117
    {
    }

    public class FRequiredduringschedulingignoredduringexecution
    {
        public _118 _ { get; set; }
        public FNodeselectorterms fnodeSelectorTerms { get; set; }
    }

    public class _118
    {
    }

    public class FNodeselectorterms
    {
    }

    public class FStatus
    {
        public FConditions fconditions { get; set; }
        public FContainerstatuses fcontainerStatuses { get; set; }
        public FHostip fhostIP { get; set; }
        public FPhase fphase { get; set; }
        public FPodip fpodIP { get; set; }
        public FPodips fpodIPs { get; set; }
        public FStarttime fstartTime { get; set; }
    }

    public class FConditions
    {
        public _119 _ { get; set; }
        public KTypePodscheduled ktypePodScheduled { get; set; }
        public KTypeContainersready ktypeContainersReady { get; set; }
        public KTypeInitialized ktypeInitialized { get; set; }
        public KTypeReady ktypeReady { get; set; }
    }

    public class _119
    {
    }

    public class KTypePodscheduled
    {
        public _120 _ { get; set; }
        public FLastprobetime flastProbeTime { get; set; }
        public FLasttransitiontime flastTransitionTime { get; set; }
        public FMessage fmessage { get; set; }
        public FReason freason { get; set; }
        public FStatus1 fstatus { get; set; }
        public FType12 ftype { get; set; }
    }

    public class _120
    {
    }

    public class FLastprobetime
    {
    }

    public class FLasttransitiontime
    {
    }

    public class FMessage
    {
    }

    public class FReason
    {
    }

    public class FStatus1
    {
    }

    public class FType12
    {
    }

    public class KTypeContainersready
    {
        public _121 _ { get; set; }
        public FLastprobetime1 flastProbeTime { get; set; }
        public FLasttransitiontime1 flastTransitionTime { get; set; }
        public FStatus2 fstatus { get; set; }
        public FType13 ftype { get; set; }
    }

    public class _121
    {
    }

    public class FLastprobetime1
    {
    }

    public class FLasttransitiontime1
    {
    }

    public class FStatus2
    {
    }

    public class FType13
    {
    }

    public class KTypeInitialized
    {
        public _122 _ { get; set; }
        public FLastprobetime2 flastProbeTime { get; set; }
        public FLasttransitiontime2 flastTransitionTime { get; set; }
        public FStatus3 fstatus { get; set; }
        public FType14 ftype { get; set; }
    }

    public class _122
    {
    }

    public class FLastprobetime2
    {
    }

    public class FLasttransitiontime2
    {
    }

    public class FStatus3
    {
    }

    public class FType14
    {
    }

    public class KTypeReady
    {
        public _123 _ { get; set; }
        public FLastprobetime3 flastProbeTime { get; set; }
        public FLasttransitiontime3 flastTransitionTime { get; set; }
        public FStatus4 fstatus { get; set; }
        public FType15 ftype { get; set; }
    }

    public class _123
    {
    }

    public class FLastprobetime3
    {
    }

    public class FLasttransitiontime3
    {
    }

    public class FStatus4
    {
    }

    public class FType15
    {
    }

    public class FContainerstatuses
    {
    }

    public class FHostip
    {
    }

    public class FPhase
    {
    }

    public class FPodip
    {
    }

    public class FPodips
    {
        public _124 _ { get; set; }
        public KIp1721702 kip1721702 { get; set; }
        public KIp192168492 kip192168492 { get; set; }
        public KIp1721703 kip1721703 { get; set; }
    }

    public class _124
    {
    }

    public class KIp1721702
    {
        public _125 _ { get; set; }
        public FIp fip { get; set; }
    }

    public class _125
    {
    }

    public class FIp
    {
    }

    public class KIp192168492
    {
        public _126 _ { get; set; }
        public FIp1 fip { get; set; }
    }

    public class _126
    {
    }

    public class FIp1
    {
    }

    public class KIp1721703
    {
        public _127 _ { get; set; }
        public FIp2 fip { get; set; }
    }

    public class _127
    {
    }

    public class FIp2
    {
    }

    public class FStarttime
    {
    }

    public class Spec
    {
        public Volume[] volumes { get; set; }
        public Container[] containers { get; set; }
        public string restartPolicy { get; set; }
        public int terminationGracePeriodSeconds { get; set; }
        public string dnsPolicy { get; set; }
        public Nodeselector nodeSelector { get; set; }
        public string serviceAccountName { get; set; }
        public string serviceAccount { get; set; }
        public string nodeName { get; set; }
        public Securitycontext securityContext { get; set; }
        public string schedulerName { get; set; }
        public Toleration[] tolerations { get; set; }
        public string priorityClassName { get; set; }
        public int priority { get; set; }
        public bool enableServiceLinks { get; set; }
        public string preemptionPolicy { get; set; }
        public bool hostNetwork { get; set; }
        public Affinity affinity { get; set; }
    }

    public class Nodeselector
    {
        public string kubernetesioos { get; set; }
    }

    public class Securitycontext
    {
    }

    public class Affinity
    {
        public Nodeaffinity nodeAffinity { get; set; }
    }

    public class Nodeaffinity
    {
        public Requiredduringschedulingignoredduringexecution requiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }

    public class Requiredduringschedulingignoredduringexecution
    {
        public Nodeselectorterm[] nodeSelectorTerms { get; set; }
    }

    public class Nodeselectorterm
    {
        public Matchfield[] matchFields { get; set; }
    }

    public class Matchfield
    {
        public string key { get; set; }
        public string _operator { get; set; }
        public string[] values { get; set; }
    }

    public class Volume
    {
        public string name { get; set; }
        public Configmap configMap { get; set; }
        public Secret secret { get; set; }
        public Hostpath hostPath { get; set; }
    }

    public class Configmap
    {
        public string name { get; set; }
        public Item1[] items { get; set; }
        public int defaultMode { get; set; }
    }

    public class Item1
    {
        public string key { get; set; }
        public string path { get; set; }
    }

    public class Secret
    {
        public string secretName { get; set; }
        public int defaultMode { get; set; }
    }

    public class Hostpath
    {
        public string path { get; set; }
        public string type { get; set; }
    }

    public class Container
    {
        public string name { get; set; }
        public string image { get; set; }
        public string[] args { get; set; }
        public Port[] ports { get; set; }
        public Resources resources { get; set; }
        public Volumemount[] volumeMounts { get; set; }
        public Livenessprobe livenessProbe { get; set; }
        public Readinessprobe readinessProbe { get; set; }
        public string terminationMessagePath { get; set; }
        public string terminationMessagePolicy { get; set; }
        public string imagePullPolicy { get; set; }
        public Securitycontext1 securityContext { get; set; }
        public string[] command { get; set; }
        public Startupprobe startupProbe { get; set; }
        public Env[] env { get; set; }
    }

    public class Resources
    {
        public Limits limits { get; set; }
        public Requests requests { get; set; }
    }

    public class Limits
    {
        public string memory { get; set; }
    }

    public class Requests
    {
        public string cpu { get; set; }
        public string memory { get; set; }
        public string ephemeralstorage { get; set; }
    }

    public class Livenessprobe
    {
        public Httpget httpGet { get; set; }
        public int initialDelaySeconds { get; set; }
        public int timeoutSeconds { get; set; }
        public int periodSeconds { get; set; }
        public int successThreshold { get; set; }
        public int failureThreshold { get; set; }
    }

    public class Httpget
    {
        public string path { get; set; }
        public int port { get; set; }
        public string scheme { get; set; }
        public string host { get; set; }
    }

    public class Readinessprobe
    {
        public Httpget1 httpGet { get; set; }
        public int timeoutSeconds { get; set; }
        public int periodSeconds { get; set; }
        public int successThreshold { get; set; }
        public int failureThreshold { get; set; }
    }

    public class Httpget1
    {
        public string path { get; set; }
        public int port { get; set; }
        public string scheme { get; set; }
        public string host { get; set; }
    }

    public class Securitycontext1
    {
        public Capabilities capabilities { get; set; }
        public bool readOnlyRootFilesystem { get; set; }
        public bool allowPrivilegeEscalation { get; set; }
        public bool privileged { get; set; }
    }

    public class Capabilities
    {
        public string[] add { get; set; }
        public string[] drop { get; set; }
    }

    public class Startupprobe
    {
        public Httpget2 httpGet { get; set; }
        public int initialDelaySeconds { get; set; }
        public int timeoutSeconds { get; set; }
        public int periodSeconds { get; set; }
        public int successThreshold { get; set; }
        public int failureThreshold { get; set; }
    }

    public class Httpget2
    {
        public string path { get; set; }
        public int port { get; set; }
        public string host { get; set; }
        public string scheme { get; set; }
    }

    public class Port
    {
        public string name { get; set; }
        public int containerPort { get; set; }
        public string protocol { get; set; }
    }

    public class Volumemount
    {
        public string name { get; set; }
        public bool readOnly { get; set; }
        public string mountPath { get; set; }
    }

    public class Env
    {
        public string name { get; set; }
        public Valuefrom valueFrom { get; set; }
    }

    public class Valuefrom
    {
        public Fieldref fieldRef { get; set; }
    }

    public class Fieldref
    {
        public string apiVersion { get; set; }
        public string fieldPath { get; set; }
    }

    public class Toleration
    {
        public string key { get; set; }
        public string _operator { get; set; }
        public string effect { get; set; }
        public int tolerationSeconds { get; set; }
    }

    public class Status
    {
        public string phase { get; set; }
        public Condition[] conditions { get; set; }
        public string hostIP { get; set; }
        public string podIP { get; set; }
        public Podip[] podIPs { get; set; }
        public DateTime startTime { get; set; }
        public Containerstatus[] containerStatuses { get; set; }
        public string qosClass { get; set; }
    }

    public class Condition
    {
        public string type { get; set; }
        public string status { get; set; }
        public object lastProbeTime { get; set; }
        public DateTime lastTransitionTime { get; set; }
    }

    public class Podip
    {
        public string ip { get; set; }
    }

    public class Containerstatus
    {
        public string name { get; set; }
        public State state { get; set; }
        public Laststate lastState { get; set; }
        public bool ready { get; set; }
        public int restartCount { get; set; }
        public string image { get; set; }
        public string imageID { get; set; }
        public string containerID { get; set; }
        public bool started { get; set; }
    }

    public class State
    {
        public Running running { get; set; }
    }

    public class Running
    {
        public DateTime startedAt { get; set; }
    }

    public class Laststate
    {
        public Terminated terminated { get; set; }
    }

    public class Terminated
    {
        public int exitCode { get; set; }
        public string reason { get; set; }
        public DateTime startedAt { get; set; }
        public DateTime finishedAt { get; set; }
        public string containerID { get; set; }
    }

}
