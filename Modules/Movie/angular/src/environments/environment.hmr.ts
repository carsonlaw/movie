export const environment = {
  production: false,
  hmr: true,
  application: {
    name: 'Movie',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44341',
    clientId: 'Movie_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'Movie',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44361',
    },
  },
  localization: {
    defaultResourceName: 'Movie',
  },
};
