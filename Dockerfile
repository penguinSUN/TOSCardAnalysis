FROM microsoft/aspnetcore-build

MAINTAINER "jhra790723@gmail.com"

ENV ASPNETCORE_ENVIRONMENT Production

WORKDIR /src
COPY . /src

EXPOSE 80


CMD ["top"]
