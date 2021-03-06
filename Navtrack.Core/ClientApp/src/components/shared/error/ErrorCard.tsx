import React from "react";
import { ApiError } from "../../../services/httpClient/AppError";

type Props = {
  error?: ApiError<object>;
};

export default function ErrorCard(props: Props) {
  const errors = [401, 403, 404];
  const showError = errors.findIndex((x) => x === props.error?.status) > -1;

  return (
    <>
      {showError && (
        <div className="bg-white shadow p-3 rounded flex">
          {props.error?.status === 401 && <>Unauthorized.</>}
          {props.error?.status === 403 && <>Forbidden.</>}
          {props.error?.status === 404 && <>Page not found.</>}
        </div>
      )}
    </>
  );
}
