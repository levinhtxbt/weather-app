ARG VARIANT=16
FROM mcr.microsoft.com/devcontainers/javascript-node:0-${VARIANT}

RUN npm install -g http-server @vue/cli @vue/cli-service-global

#RUN su node -c "umask 0002 && npm install -g http-server @vue/cli @vue/cli-service-global"
#WORKDIR /app

EXPOSE 8080