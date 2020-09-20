import React, { useState, useMemo, useEffect } from "react";
import { IntlProvider } from "react-intl";
import { BrowserRouter } from "react-router-dom";
import AdminLayout from "./components/shared/layouts/admin/AdminLayout";
import LoginLayout from "./components/shared/layouts/login/LoginLayout";
import Notifications from "./components/shared/notifications/Notifications";
import { AccountService } from "./services/AccountService";
import { AppContext, CreateAppContext, SaveToLocalStorage } from "./services/appContext/AppContext";
import { AppContextAccessor } from "./services/appContext/AppContextAccessor";
import { AssetsService } from "./services/AssetService";
import { AuthenticationService } from "./services/authentication/AuthenticationService";
import translations from "./translations";

export default function App() {
  const [appContext, setAppContext] = useState(CreateAppContext());
  AppContextAccessor.setAppContextSetter(setAppContext);
  AppContextAccessor.setAppContextGetter(() => appContext);
  const appContextWrapper = useMemo(() => ({ appContext, setAppContext }), [
    appContext,
    setAppContext
  ]);

  useEffect(() => {
    SaveToLocalStorage(appContext);
  }, [appContext]);

  useEffect(() => {
    (async () => {
      await AuthenticationService.checkAndRenewAccessToken();
    })();
  }, []);

  useEffect(() => {
    if (appContext.authenticationInfo.authenticated) {
      AssetsService.init();
      AccountService.getUserInfo();
    } else {
      AssetsService.clear();
    }
  }, [appContext.authenticationInfo]);

  return (
    <div className="text-gray-900">
      <BrowserRouter>
        <AppContext.Provider value={appContextWrapper}>
          <IntlProvider locale="en" messages={translations["en"]}>
            <Notifications />
            {AuthenticationService.isAuthenticated() ? <AdminLayout /> : <LoginLayout />}
          </IntlProvider>
        </AppContext.Provider>
      </BrowserRouter>
    </div>
  );
}
