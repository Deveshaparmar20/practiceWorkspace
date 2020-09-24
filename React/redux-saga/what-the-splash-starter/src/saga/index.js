import { takeEvery } from 'redux-saga/effects';

import { IMAGES } from '../constants';

function* handleImagesLoad() {
    console.log('fetching images from unsplash')
}

//watcher
function* rootSaga() {
    yield takeEvery(IMAGES.LOAD, handleImagesLoad);
}

// watcher saga -> actions ->worker saga

export default rootSaga;
