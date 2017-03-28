<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', 'WelcomeController@index');
Route::get('/sondage/{n}', 'WelcomeController@sondage');
Route::get('/oeuvres/{n}', 'WelcomeController@oeuvres');
Route::get('/oeuvre/{s_id}/{o_id}', 'WelcomeController@oeuvre');
Route::post('/voter/traitement/{s_id}/{o_id}', 'VoteController@postInfos');
Route::get('/remercie', 'WelcomeController@remercie');



