---
type: docs
no_list: true
---

[![License](https://img.shields.io/github/license/mashape/apistatus.svg?style=flat-square)](https://github.com/tomkerkhove/promitor/blob/master/LICENSE)
[![Build Status](https://img.shields.io/azure-devops/build/tomkerkhove/promitor/50/master.svg?label=Scraper%20Agent%20-%20CI&style=flat-square)](https://dev.azure.com/tomkerkhove/Promitor/_build/latest?definitionId=50&branchName=master)
[![Docker Pulls](https://img.shields.io/docker/pulls/tomkerkhove/promitor-agent-scraper.svg?style=flat-square)](https://hub.docker.com/r/tomkerkhove/promitor-agent-scraper/)
[![Docker Stars](https://img.shields.io/docker/stars/tomkerkhove/promitor-agent-scraper.svg?style=flat-square)](https://hub.docker.com/r/tomkerkhove/promitor-agent-scraper/)
[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/promitor?style=flat-square)](https://artifacthub.io/packages/search?repo=promitor)
[![Donate](https://img.shields.io/badge/Donate%20via-GitHub-blue.svg?style=flat-square)](https://github.com/users/tomkerkhove/sponsorship)

{{% alert color="primary" %}}
**Promitor** is an Azure Monitor scraper which makes the metrics available
for metric systems such as Atlassian Statuspage, Prometheus and StatsD.
{{% /alert %}}

<img src="/images/promitor.svg" alt="Promitor" width=400>

### Running Promitor Scraper

```shell
docker run -d -p 8999:80 --name promitor-agent-scraper \
                         --env PROMITOR_AUTH_APPID='<azure-ad-app-id>'   \
                         --env-file C:/Promitor/az-mon-auth.creds \
                         --volume C:/Promitor/metrics-declaration.yaml:/config/metrics-declaration.yaml \
                         --volume C:/Promitor/runtime.yaml:/config/runtime.yaml \
                         ghcr.io/tomkerkhove/promitor-agent-scraper:2.0.0-rc
```

Docker image is available on [Docker Hub](https://hub.docker.com/r/tomkerkhove/promitor-agent-scraper/).

### Features

- Automatically scrapes Azure Monitor metrics (single and multi-dimensional) across various subscription &
 resource groups
- Automatically pushes metrics to systems such as Atlassian Statuspage, Prometheus and StatsD
- Easy to declare metrics to scrape via metrics-as-code or automatically discover resources
- Built-in support for a variety of Azure services ([overview](configuration/v2.x/metrics#supported-azure-services))
- Easily deployable via Docker & Kubernetes
- Sends telemetry to container logs & Azure Application Insights
- Available for Linux & Windows runtimes
- Support for all Azure clouds

And there is more on the way - Check our [backlog](https://github.com/tomkerkhove/promitor/issues)
and vote for features!

### Documentation

<div class="card-deck">
  <div class="card">
    <div class="card-body">
      <h5 class="card-title"><b>How It Works</b></h5>
      <p class="card-text">Learn more about how Promitor scrapes metrics.</p>
      <a href="concepts" class="stretched-link"></a>
    </div>
  </div>
  <div class="card">
    <div class="card-body">
      <h5 class="card-title"><b>Quickstarts</b></h5>
      <p class="card-text">A collection of tutorials with code samples to get you started quickly with Dapr.</p>
      <a href="}" class="stretched-link"></a>
    </div>
  </div>
  <div class="card">
    <div class="card-body">
      <h5 class="card-title"><b>Concepts</b></h5>
      <p class="card-text">Learn about Dapr, including its main features and capabilities.</p>
      <a href="" class="stretched-link"></a>
    </div>
  </div>
</div>

### Support

Promitor is actively maintained and developed with best-effort support.

We do welcome PRs that implement features from our backlog and are always happy
to help you incorporate Promitor in your infrastructure, but do not provide 24/7
support. Are you having issues or feature requests?

Feel free to [let us know](https://github.com/tomkerkhove/promitor/issues/new/choose)!

### End-users

We are proud to have the following end-users(s) running Promitor in production:

![Adobe](./media/logos/end-users/adobe.png)
![ResDiary](./media/logos/end-users/resdiary.png)
![Trynz](./media/logos/end-users/trynz.png)
![Vsoft](./media/logos/end-users/vsoft.png)
![Walmart Labs](./media/logos/end-users/walmart-labs.jpg)

Are you a Promitor user? Let us know and [get listed](https://forms.gle/hjcpaaVFa1A1hZaK6)!

Learn more about how they are using Promitor:

- ["Monitor Azure Resources using Promitor"](https://medium.com/resdiary-product-team/monitor-azure-resources-using-promitor-b3d8384867c1)
 by ResDiary

### Thank you

We'd like to thank the following service(s) for supporting our open-source initiative!

- **Netlify** allows us to provide previews of our documentation changes in our
  pull requests that make it easier to review them.

<!-- markdownlint-disable MD033 -->
  <a href="https://www.netlify.com">
    <img src="https://www.netlify.com/img/global/badges/netlify-color-bg.svg" alt="Deploys by Netlify" />
  </a>
<!-- markdownlint-enable -->

But they are not the only one we'd like to thank!

For a full list of services, tooling & NuGet packages that support us -
 Have a look at our [Thank you](thank-you) page!

### License Information

This is licensed under The MIT License (MIT). Which means that you can use, copy,
modify, merge, publish, distribute, sublicense, and/or sell copies of the web application.
But you always need to state that Tom Kerkhove is the original author of this web
application.