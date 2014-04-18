/*
   Copyright 2012 University of Washington

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

#ifndef _COMETPREPROCESS_H_
#define _COMETPREPROCESS_H_

#include "Common.h"
#include "ThreadPool.h"
#include "Profiler.h"

struct PreprocessThreadData
{
   Spectrum mstSpectrum;
   int iAnalysisType;
   int iFileLastScan;
   bool *pbMemoryPool;  //MH: Manages active memory pool

   PreprocessThreadData()
   {
   }

   PreprocessThreadData(Spectrum &spec_in,
                        int iAnalysisType_in,
                        int iFileLastScan_in)
   {
      mstSpectrum = spec_in;
      iAnalysisType = iAnalysisType_in;
      iFileLastScan = iFileLastScan_in;
   }

   ~PreprocessThreadData()
   {
      //MH: Mark that the memory is no longer in use. 
      //DO NOT FREE MEMORY HERE. Just release pointer.
      if(pbMemoryPool!=NULL) *pbMemoryPool=false;
      pbMemoryPool=NULL;
   }

   void SetMemory(bool *pbMemoryPool_in)
   {
      pbMemoryPool = pbMemoryPool_in;
   }
};


class CometPreprocess
{
public:
   CometPreprocess();
   ~CometPreprocess();

   static void Reset();
   static bool LoadAndPreprocessSpectra(MSReader &mstReader,
                                        int iFirstScan, 
                                        int iLastScan, 
                                        int iAnalysisType,
                                        int minNumThreads,
                                        int maxNumThreads);
   static void PreprocessThreadProc(PreprocessThreadData *pPreprocessThreadData);
   static bool DoneProcessingAllSpectra();
   static bool AllocateMemory(int maxNumThreads);
   static bool DeallocateMemory(int maxNumThreads);
   
private:
   
   // Private static methods
   static bool PreprocessSpectrum(Spectrum &spec,
                                  double *pdTempRawData,
                                  double *pdTmpFastXcorrData,
                                  double *pdSmoothedSpectrum,
                                  double *pdPeakExtracted);
   static bool CheckExistOutFile(int iCharge,
                                 int iScanNum);
   static bool AdjustMassTol(struct Query *pScoring);
   static void PreloadIons(MSReader &mstReader,
                           Spectrum &spec,
                           bool bNext=false,
                           int scNum=0);
   static bool CheckActivationMethodFilter(MSActivation act);
   static bool CheckExit(int iAnalysisType,
                         int iScanNum, 
                         int iTotalScans, 
                         int iLastScan,
                         int iReaderLastScan,
                         int iNumSpectraLoaded);
   static bool Preprocess(struct Query *pScoring,
                          Spectrum mstSpectrum,
                          double *pdTempRawData,
                          double *pdTmpFastXcorrData,
                          double *pdSmoothedSpectrum,
                          double *pdPeakExtracted);
   static bool LoadIons(struct Query *pScoring,
                        Spectrum mstSpectrum,
                        struct PreprocessStruct *pPre);
   static void MakeCorrData(double *pdTempRawData,
                            struct Query *pScoring,
                            struct PreprocessStruct *pPre);
   static bool Smooth(double *data,
                      int iArraySize,
                      double *pdSmoothedSpectrum);
   static bool PeakExtract(double *data,
                           int iArraySize,
                           double *pdPeakExtracted);
   static void GetTopIons(double *pdTempRawData,
                          struct msdata *pTempSpData,
                          int iArraySize);
   static int QsortByIon(const void *p0,
                         const void *p1);
   static void StairStep(struct msdata *pTempSpData);


   // Private member variables
   static Mutex _maxChargeMutex;
   static bool _bFirstScan;
   static bool _bDoneProcessingAllSpectra;

   //MH: Common memory to be shared by all threads during spectral processing
   static bool *pbMemoryPool;             //MH: Regulator of memory use
   static double **pdTempRawDataArr;      //MH: Number of arrays equals threads
   static double **pdTmpFastXcorrDataArr; //MH: Ditto
   static double **pdSmoothedSpectrumArr; //MH: Ditto
   static double **pdPeakExtractedArr;    //MH: Ditto
};

#endif // _COMETPREPROCESS_H_
