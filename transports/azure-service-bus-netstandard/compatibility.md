---
title: Backwards Compatibility
summary: Describes the requirements for backward compatibility with Legacy Azure Service Bus
component: ASBS
tags:
 - Azure
reviewed: 2018-06-21
---

The Azure Service Bus transport is backward compatible with the Legacy Azure Service Bus transport under certain conditions.

## Conditions

### Forwarding topology

The Azure Service Bus transport only supports the [forwarding topology](/transports/azure-service-bus/topologies/#versions-7-and-above-forwarding-topology), an entity layout where a topic is used for publishing between the endpoints.

### Single namespace

The Azure Service Bus transport only supports a single namespace.

### Topic path must match

Both transports must be configured using the same topic path for publishing to work properly. This implies that the topic used by the endpoints using Azure Service Bus for .NET Standard transport must match topic used by the endpoints on Azure Service Bus (see [bundle prefix](/transports/azure-service-bus/configuration/full.md#configuring-the-topology-forwarding-topology) for details).

### Namespace alias is not used

The Azure Service Bus transport doesn't support [namespace aliases](/transports/azure-service-bus/securing-connection-strings.md).
