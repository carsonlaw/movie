export const environment = {
  production: true,
  hmr: false,
  application: {
    name: 'UCenter',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44305',
    clientId: 'UCenter_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'UCenter',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44305',
    },
  },
  localization: {
    defaultResourceName: 'UCenter',
  },
};
