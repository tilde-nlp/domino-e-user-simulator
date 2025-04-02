using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models.Kubernetes
{
    public class ServiceInfoDTO
    {
        public string kind { get; set; }
        public string apiVersion { get; set; }
        public Metadata metadata { get; set; }
        public Spec spec { get; set; }
        public Status status { get; set; }
    }

    public class Metadata
    {
        public string name { get; set; }
        public string _namespace { get; set; }
        public string uid { get; set; }
        public string resourceVersion { get; set; }
        public int generation { get; set; }
        public DateTime creationTimestamp { get; set; }
        public Annotations annotations { get; set; }
        public Managedfield[] managedFields { get; set; }
    }

    public class Annotations
    {
        public string deploymentkubernetesiorevision { get; set; }
        [JsonProperty(PropertyName = "serving.knative.dev/creator")]
        public string creator { get; set; }
        [JsonProperty(PropertyName = "serving.knative.dev/lastModifier")]
        public string lastModifier { get; set; }
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
        public FSpec fspec { get; set; }
        public FMetadata1 fmetadata { get; set; }
        public FStatus fstatus { get; set; }
    }

    public class FSpec
    {
        public FProgressdeadlineseconds fprogressDeadlineSeconds { get; set; }
        public FReplicas freplicas { get; set; }
        public FRevisionhistorylimit frevisionHistoryLimit { get; set; }
        public FSelector fselector { get; set; }
        public FStrategy fstrategy { get; set; }
        public FTemplate ftemplate { get; set; }
    }

    public class FProgressdeadlineseconds
    {
    }

    public class FReplicas
    {
    }

    public class FRevisionhistorylimit
    {
    }

    public class FSelector
    {
    }

    public class FStrategy
    {
        public FRollingupdate frollingUpdate { get; set; }
        public FType ftype { get; set; }
    }

    public class FRollingupdate
    {
        public _ _ { get; set; }
        public FMaxsurge fmaxSurge { get; set; }
        public FMaxunavailable fmaxUnavailable { get; set; }
    }

    public class _
    {
    }

    public class FMaxsurge
    {
    }

    public class FMaxunavailable
    {
    }

    public class FType
    {
    }

    public class FTemplate
    {
        public FMetadata fmetadata { get; set; }
        public FSpec1 fspec { get; set; }
    }

    public class FMetadata
    {
        public FLabels flabels { get; set; }
    }

    public class FLabels
    {
        public _1 _ { get; set; }
        public FApp fapp { get; set; }
    }

    public class _1
    {
    }

    public class FApp
    {
    }

    public class FSpec1
    {
        public FContainers fcontainers { get; set; }
        public FDnspolicy fdnsPolicy { get; set; }
        public FImagepullsecrets fimagePullSecrets { get; set; }
        public FRestartpolicy frestartPolicy { get; set; }
        public FSchedulername fschedulerName { get; set; }
        public FSecuritycontext fsecurityContext { get; set; }
        public FTerminationgraceperiodseconds fterminationGracePeriodSeconds { get; set; }
        public FVolumes fvolumes { get; set; }
    }

    public class FContainers
    {
        public KNameEsaintentServiceDeployerServe knameesaintentservicedeployerserve { get; set; }
    }

    public class KNameEsaintentServiceDeployerServe
    {
        public _2 _ { get; set; }
        public FEnv fenv { get; set; }
        public FImage fimage { get; set; }
        public FImagepullpolicy fimagePullPolicy { get; set; }
        public FName6 fname { get; set; }
        public FPorts fports { get; set; }
        public FResources fresources { get; set; }
        public FTerminationmessagepath fterminationMessagePath { get; set; }
        public FTerminationmessagepolicy fterminationMessagePolicy { get; set; }
        public FVolumemounts fvolumeMounts { get; set; }
    }

    public class _2
    {
    }

    public class FEnv
    {
        public _3 _ { get; set; }
        public KNameACT knameACT { get; set; }
        public KNameDATAFILE knameDATAFILE { get; set; }
        public KNameDO_XVAL knameDO_XVAL { get; set; }
        public KNameMODEL_PREFIX knameMODEL_PREFIX { get; set; }
        public KNameVECTORIZER_ADDRESS knameVECTORIZER_ADDRESS { get; set; }
        public KNameVECTORIZER_PORT knameVECTORIZER_PORT { get; set; }
    }

    public class _3
    {
    }

    public class KNameACT
    {
        public _4 _ { get; set; }
        public FName fname { get; set; }
        public FValue fvalue { get; set; }
    }

    public class _4
    {
    }

    public class FName
    {
    }

    public class FValue
    {
    }

    public class KNameDATAFILE
    {
        public _5 _ { get; set; }
        public FName1 fname { get; set; }
        public FValue1 fvalue { get; set; }
    }

    public class _5
    {
    }

    public class FName1
    {
    }

    public class FValue1
    {
    }

    public class KNameDO_XVAL
    {
        public _6 _ { get; set; }
        public FName2 fname { get; set; }
        public FValue2 fvalue { get; set; }
    }

    public class _6
    {
    }

    public class FName2
    {
    }

    public class FValue2
    {
    }

    public class KNameMODEL_PREFIX
    {
        public _7 _ { get; set; }
        public FName3 fname { get; set; }
        public FValue3 fvalue { get; set; }
    }

    public class _7
    {
    }

    public class FName3
    {
    }

    public class FValue3
    {
    }

    public class KNameVECTORIZER_ADDRESS
    {
        public _8 _ { get; set; }
        public FName4 fname { get; set; }
        public FValue4 fvalue { get; set; }
    }

    public class _8
    {
    }

    public class FName4
    {
    }

    public class FValue4
    {
    }

    public class KNameVECTORIZER_PORT
    {
        public _9 _ { get; set; }
        public FName5 fname { get; set; }
        public FValue5 fvalue { get; set; }
    }

    public class _9
    {
    }

    public class FName5
    {
    }

    public class FValue5
    {
    }

    public class FImage
    {
    }

    public class FImagepullpolicy
    {
    }

    public class FName6
    {
    }

    public class FPorts
    {
        public _10 _ { get; set; }
        public KContainerport80ProtocolTCP kcontainerPort80protocolTCP { get; set; }
    }

    public class _10
    {
    }

    public class KContainerport80ProtocolTCP
    {
        public _11 _ { get; set; }
        public FContainerport fcontainerPort { get; set; }
        public FName7 fname { get; set; }
        public FProtocol fprotocol { get; set; }
    }

    public class _11
    {
    }

    public class FContainerport
    {
    }

    public class FName7
    {
    }

    public class FProtocol
    {
    }

    public class FResources
    {
        public _12 _ { get; set; }
        public FLimits flimits { get; set; }
        public FRequests frequests { get; set; }
    }

    public class _12
    {
    }

    public class FLimits
    {
        public _13 _ { get; set; }
        public FCpu fcpu { get; set; }
        public FMemory fmemory { get; set; }
    }

    public class _13
    {
    }

    public class FCpu
    {
    }

    public class FMemory
    {
    }

    public class FRequests
    {
        public _14 _ { get; set; }
        public FCpu1 fcpu { get; set; }
        public FMemory1 fmemory { get; set; }
    }

    public class _14
    {
    }

    public class FCpu1
    {
    }

    public class FMemory1
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
        public _15 _ { get; set; }
        public KMountpathData kmountPathdata { get; set; }
    }

    public class _15
    {
    }

    public class KMountpathData
    {
        public _16 _ { get; set; }
        public FMountpath fmountPath { get; set; }
        public FName8 fname { get; set; }
    }

    public class _16
    {
    }

    public class FMountpath
    {
    }

    public class FName8
    {
    }

    public class FDnspolicy
    {
    }

    public class FImagepullsecrets
    {
        public _17 _ { get; set; }
        public KNamePullSecret knamepullsecret { get; set; }
    }

    public class _17
    {
    }

    public class KNamePullSecret
    {
        public _18 _ { get; set; }
        public FName9 fname { get; set; }
    }

    public class _18
    {
    }

    public class FName9
    {
    }

    public class FRestartpolicy
    {
    }

    public class FSchedulername
    {
    }

    public class FSecuritycontext
    {
    }

    public class FTerminationgraceperiodseconds
    {
    }

    public class FVolumes
    {
        public _19 _ { get; set; }
        public KNameMyDockerStoragePv knamemydockerstoragepv { get; set; }
    }

    public class _19
    {
    }

    public class KNameMyDockerStoragePv
    {
        public _20 _ { get; set; }
        public FName10 fname { get; set; }
        public FPersistentvolumeclaim fpersistentVolumeClaim { get; set; }
    }

    public class _20
    {
    }

    public class FName10
    {
    }

    public class FPersistentvolumeclaim
    {
        public _21 _ { get; set; }
        public FClaimname fclaimName { get; set; }
    }

    public class _21
    {
    }

    public class FClaimname
    {
    }

    public class FMetadata1
    {
        public FAnnotations fannotations { get; set; }
    }

    public class FAnnotations
    {
        public _22 _ { get; set; }
        public FDeploymentKubernetesIoRevision fdeploymentkubernetesiorevision { get; set; }
    }

    public class _22
    {
    }

    public class FDeploymentKubernetesIoRevision
    {
    }

    public class FStatus
    {
        public FConditions fconditions { get; set; }
        public FObservedgeneration fobservedGeneration { get; set; }
        public FReplicas1 freplicas { get; set; }
        public FUnavailablereplicas funavailableReplicas { get; set; }
        public FUpdatedreplicas fupdatedReplicas { get; set; }
    }

    public class FConditions
    {
        public _23 _ { get; set; }
        public KTypeAvailable ktypeAvailable { get; set; }
        public KTypeProgressing ktypeProgressing { get; set; }
    }

    public class _23
    {
    }

    public class KTypeAvailable
    {
        public _24 _ { get; set; }
        public FLasttransitiontime flastTransitionTime { get; set; }
        public FLastupdatetime flastUpdateTime { get; set; }
        public FMessage fmessage { get; set; }
        public FReason freason { get; set; }
        public FStatus1 fstatus { get; set; }
        public FType1 ftype { get; set; }
    }

    public class _24
    {
    }

    public class FLasttransitiontime
    {
    }

    public class FLastupdatetime
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

    public class FType1
    {
    }

    public class KTypeProgressing
    {
        public _25 _ { get; set; }
        public FLasttransitiontime1 flastTransitionTime { get; set; }
        public FLastupdatetime1 flastUpdateTime { get; set; }
        public FMessage1 fmessage { get; set; }
        public FReason1 freason { get; set; }
        public FStatus2 fstatus { get; set; }
        public FType2 ftype { get; set; }
    }

    public class _25
    {
    }

    public class FLasttransitiontime1
    {
    }

    public class FLastupdatetime1
    {
    }

    public class FMessage1
    {
    }

    public class FReason1
    {
    }

    public class FStatus2
    {
    }

    public class FType2
    {
    }

    public class FObservedgeneration
    {
    }

    public class FReplicas1
    {
    }

    public class FUnavailablereplicas
    {
    }

    public class FUpdatedreplicas
    {
    }

    public class Spec
    {
        public int replicas { get; set; }
        public Selector selector { get; set; }
        public Template template { get; set; }
        public Strategy strategy { get; set; }
        public int revisionHistoryLimit { get; set; }
        public int progressDeadlineSeconds { get; set; }
    }

    public class Selector
    {
        public Matchlabels matchLabels { get; set; }
    }

    public class Matchlabels
    {
        public string app { get; set; }
    }

    public class Template
    {
        public Metadata1 metadata { get; set; }
        public Spec1 spec { get; set; }
    }

    public class Metadata1
    {
        public object creationTimestamp { get; set; }
        public Labels labels { get; set; }
    }

    public class Labels
    {
        public string app { get; set; }
    }

    public class Spec1
    {
        public Volume[] volumes { get; set; }
        public Container[] containers { get; set; }
        public string restartPolicy { get; set; }
        public int terminationGracePeriodSeconds { get; set; }
        public string dnsPolicy { get; set; }
        public Securitycontext securityContext { get; set; }
        public Imagepullsecret[] imagePullSecrets { get; set; }
        public string schedulerName { get; set; }
    }

    public class Securitycontext
    {
    }

    public class Volume
    {
        public string name { get; set; }
        public Persistentvolumeclaim persistentVolumeClaim { get; set; }
    }

    public class Persistentvolumeclaim
    {
        public string claimName { get; set; }
    }

    public class Container
    {
        public string name { get; set; }
        public string image { get; set; }
        public Port[] ports { get; set; }
        public Env[] env { get; set; }
        public Resources resources { get; set; }
        public Volumemount[] volumeMounts { get; set; }
        public string terminationMessagePath { get; set; }
        public string terminationMessagePolicy { get; set; }
        public string imagePullPolicy { get; set; }
    }

    public class Resources
    {
        public Limits limits { get; set; }
        public Requests requests { get; set; }
    }

    public class Limits
    {
        public string cpu { get; set; }
        public string memory { get; set; }
    }

    public class Requests
    {
        public string cpu { get; set; }
        public string memory { get; set; }
    }

    public class Port
    {
        public string name { get; set; }
        public int containerPort { get; set; }
        public string protocol { get; set; }
    }

    public class Env
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Volumemount
    {
        public string name { get; set; }
        public string mountPath { get; set; }
    }

    public class Imagepullsecret
    {
        public string name { get; set; }
    }

    public class Strategy
    {
        public string type { get; set; }
        public Rollingupdate rollingUpdate { get; set; }
    }

    public class Rollingupdate
    {
        public string maxUnavailable { get; set; }
        public string maxSurge { get; set; }
    }

    public class Status
    {
        public int observedGeneration { get; set; }
        public int replicas { get; set; }
        public int updatedReplicas { get; set; }
        public int unavailableReplicas { get; set; }
        public Condition[] conditions { get; set; }
    }

    public class Condition
    {
        public string type { get; set; }
        public string status { get; set; }
        public DateTime lastUpdateTime { get; set; }
        public DateTime lastTransitionTime { get; set; }
        public string reason { get; set; }
        public string message { get; set; }
    }


}
