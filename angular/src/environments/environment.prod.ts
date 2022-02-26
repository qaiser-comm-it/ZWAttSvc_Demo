import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ZW',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44328',
    redirectUri: baseUrl,
    clientId: 'ZW_App',
    responseType: 'code',
    scope: 'offline_access ZW',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44328',
      rootNamespace: 'ZW',
    },
  },
} as Environment;
