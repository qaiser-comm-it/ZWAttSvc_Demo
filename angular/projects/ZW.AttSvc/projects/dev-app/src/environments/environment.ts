import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'AttSvc',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44306',
    redirectUri: baseUrl,
    clientId: 'AttSvc_App',
    responseType: 'code',
    scope: 'offline_access AttSvc role email openid profile',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44306',
      rootNamespace: 'ZW.AttSvc',
    },
    AttSvc: {
      url: 'https://localhost:44327',
      rootNamespace: 'ZW.AttSvc',
    },
  },
} as Environment;
