/* tslint:disable */
/* eslint-disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpContext } from '@angular/common/http';
import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';
import { RequestBuilder } from '../request-builder';
import { Observable } from 'rxjs';
import { map, filter } from 'rxjs/operators';

import { Product } from '../models/product';

@Injectable({
  providedIn: 'root',
})
export class ProductService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation productGet
   */
  static readonly ProductGetPath = '/Product';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  productGet$Plain$Response(params?: {
    context?: HttpContext
  }
): Observable<StrictHttpResponse<Array<Product>>> {

    const rb = new RequestBuilder(this.rootUrl, ProductService.ProductGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<Product>>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `productGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productGet$Plain(params?: {
    context?: HttpContext
  }
): Observable<Array<Product>> {

    return this.productGet$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<Array<Product>>) => r.body as Array<Product>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  productGet$Json$Response(params?: {
    context?: HttpContext
  }
): Observable<StrictHttpResponse<Array<Product>>> {

    const rb = new RequestBuilder(this.rootUrl, ProductService.ProductGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<Product>>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `productGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productGet$Json(params?: {
    context?: HttpContext
  }
): Observable<Array<Product>> {

    return this.productGet$Json$Response(params).pipe(
      map((r: StrictHttpResponse<Array<Product>>) => r.body as Array<Product>)
    );
  }

  /**
   * Path part for operation productPut
   */
  static readonly ProductPutPath = '/Product';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productPut$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPut$Plain$Response(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<StrictHttpResponse<Product>> {

    const rb = new RequestBuilder(this.rootUrl, ProductService.ProductPutPath, 'put');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Product>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `productPut$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPut$Plain(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<Product> {

    return this.productPut$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<Product>) => r.body as Product)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productPut$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPut$Json$Response(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<StrictHttpResponse<Product>> {

    const rb = new RequestBuilder(this.rootUrl, ProductService.ProductPutPath, 'put');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Product>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `productPut$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPut$Json(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<Product> {

    return this.productPut$Json$Response(params).pipe(
      map((r: StrictHttpResponse<Product>) => r.body as Product)
    );
  }

  /**
   * Path part for operation productPost
   */
  static readonly ProductPostPath = '/Product';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost$Plain$Response(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<StrictHttpResponse<Product>> {

    const rb = new RequestBuilder(this.rootUrl, ProductService.ProductPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Product>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `productPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost$Plain(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<Product> {

    return this.productPost$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<Product>) => r.body as Product)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productPost$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost$Json$Response(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<StrictHttpResponse<Product>> {

    const rb = new RequestBuilder(this.rootUrl, ProductService.ProductPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Product>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `productPost$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost$Json(params?: {
    context?: HttpContext
    body?: Product
  }
): Observable<Product> {

    return this.productPost$Json$Response(params).pipe(
      map((r: StrictHttpResponse<Product>) => r.body as Product)
    );
  }

  /**
   * Path part for operation productDelete
   */
  static readonly ProductDeletePath = '/Product';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productDelete()` instead.
   *
   * This method doesn't expect any request body.
   */
  productDelete$Response(params?: {
    id?: number;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<void>> {

    const rb = new RequestBuilder(this.rootUrl, ProductService.ProductDeletePath, 'delete');
    if (params) {
      rb.query('id', params.id, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: '*/*',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `productDelete$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productDelete(params?: {
    id?: number;
    context?: HttpContext
  }
): Observable<void> {

    return this.productDelete$Response(params).pipe(
      map((r: StrictHttpResponse<void>) => r.body as void)
    );
  }

}
