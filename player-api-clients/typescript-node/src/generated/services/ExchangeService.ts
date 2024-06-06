/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CommonOperationResponse } from '../models/CommonOperationResponse';
import type { ConvertTokenRequestInput } from '../models/ConvertTokenRequestInput';
import type { GetQuoteResponse } from '../models/GetQuoteResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class ExchangeService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Returns the maximum necessary input amount for a token trade, given a desired output amount
   * @param tokenIn
   * @param tokenOut
   * @param amountOut
   * @param chainId
   * @returns GetQuoteResponse
   * @throws ApiError
   */
  public getQuoteForInput(
    tokenIn: string,
    tokenOut: string,
    amountOut: string,
    chainId?: number,
  ): CancelablePromise<GetQuoteResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/exchange/quote/input',
      query: {
        tokenIn: tokenIn,
        tokenOut: tokenOut,
        amountOut: amountOut,
        chainId: chainId,
      },
    });
  }

  /**
   * Returns the minimum expected output amount for a token trade, given an input amount
   * @param tokenIn
   * @param tokenOut
   * @param amountIn
   * @param chainId
   * @returns GetQuoteResponse
   * @throws ApiError
   */
  public getQuoteForOutput(
    tokenIn: string,
    tokenOut: string,
    amountIn: string,
    chainId?: number,
  ): CancelablePromise<GetQuoteResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/exchange/quote/output',
      query: {
        tokenIn: tokenIn,
        tokenOut: tokenOut,
        amountIn: amountIn,
        chainId: chainId,
      },
    });
  }

  /**
   * Swap an exact amount of `tokenIn` for a minimum amount of `tokenOut`
   * @param entityId
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public convertInput(
    entityId: string,
    requestBody: ConvertTokenRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/exchange/users/{entityId}/convert/input',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Swap a maximum amount of `tokenIn` for an exact amount of `tokenOut`
   * @param entityId
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public convertToOutput(
    entityId: string,
    requestBody: ConvertTokenRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/exchange/users/{entityId}/convert/output',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
