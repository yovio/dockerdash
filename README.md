# dockerdash

[![Build status](https://ci.appveyor.com/api/projects/status/8l78yx2m55f8mnrf?svg=true)](https://ci.appveyor.com/project/yovio/dockerdash)
[![Layers](https://images.microbadger.com/badges/image/yovio/dockerdash.svg)](https://microbadger.com/images/yovio/dockerdash)
[![Version](https://images.microbadger.com/badges/version/yovio/dockerdash.svg)](https://microbadger.com/images/yovio/dockerdash)

Docker dashboard is compatible with Docker v1.12.x

### Run

Connect to Docker remote API by mounting the unix socket:

```
docker pull yovio/dockerdash:latest

docker run -d -p 5050:5050 \
-v /var/run/docker.sock:/var/run/docker.sock \
-e DOCKERDASH_USER='admin' \
-e DOCKERDASH_PASSWORD='changeme' \
--name dockerdash \
yovio/dockerdash
```

Connect to a Docker remote API via TCP:

```
docker run -d -p 5050:5050 \
-e DOCKER_REMOTE_API='tcp://192.168.1.134:4243' \
-e DOCKERDASH_USER='admin' \
-e DOCKERDASH_PASSWORD='changeme' \
--name dockerdash \
yovio/dockerdash
```

### Features

* Host information
* Containers real-time status via web sockets
* Container details, resource usage and logs
* Images information
* Networks information
* Dashboard user/password authentication

### Todo

* Swarm information
* Nodes status and details
* Services status and details

### Dev Stack

* .NET Platform Standard 1.6
* ASP.NET Core
* Docker.DotNet
* SignalR
* JWT auth
* Vuejs
* Bootstrap

### Screenshots 

***Host containers***

![Containers](https://raw.githubusercontent.com/stefanprodan/dockerdash/master/screens/host-containers-dockerdash.png)

***Container detais***

![Container](https://raw.githubusercontent.com/stefanprodan/dockerdash/master/screens/container-details-dockerdash.png)

***Host images***

![Containers](https://raw.githubusercontent.com/stefanprodan/dockerdash/master/screens/host-images-dockerdash.png)

***Host networks***

![Containers](https://raw.githubusercontent.com/stefanprodan/dockerdash/master/screens/host-networks-dockerdash.png)
