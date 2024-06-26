/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GenerateSessionRequestResponse } from '../models/GenerateSessionRequestResponse';
import type { GenerateSessionUrlRequestInput } from '../models/GenerateSessionUrlRequestInput';
import type { GetActiveSessionResponse } from '../models/GetActiveSessionResponse';
import type { GetSessionRequestResponse } from '../models/GetSessionRequestResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class SessionsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * @param entityId
   * @param requestBody
   * @returns GenerateSessionRequestResponse
   * @throws ApiError
   */
  public createSessionRequest(
    entityId: string,
    requestBody: GenerateSessionUrlRequestInput,
  ): CancelablePromise<GenerateSessionRequestResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/sessions/users/{entityId}/request',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * @param requestId
   * @returns GetSessionRequestResponse
   * @throws ApiError
   */
  public getSessionRequest(
    requestId: string,
  ): CancelablePromise<GetSessionRequestResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/sessions/request/{requestId}',
      path: {
        requestId: requestId,
      },
    });
  }

  /**
   * @param entityId
   * @param accountAddress
   * @param chainId
   * @returns GetActiveSessionResponse
   * @throws ApiError
   */
  public getActiveSession(
    entityId: string,
    accountAddress: string,
    chainId?: number,
  ): CancelablePromise<GetActiveSessionResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/sessions/users/{entityId}/{accountAddress}/active',
      path: {
        entityId: entityId,
        accountAddress: accountAddress,
      },
      query: {
        chainId: chainId,
      },
    });
  }
}
