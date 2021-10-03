---
type: docs
title: "Metrics"
linkTitle: "Metrics"
weight: 20
---

All the Azure Monitor metrics that need to be scraped are consolidated in one YAML
file which is referred to as the metric declaration.

This declaration defines the overall Azure metadata and all the metrics you want to expose.

Every metric describes the Azure Monitor metric that it represents and what Azure resources that should be scraped.
 It allows you to statically declaring the resources to scrape and/or use [automatic resource discovery](./../../../concepts/how-it-works.md#using-resource-discovery).
