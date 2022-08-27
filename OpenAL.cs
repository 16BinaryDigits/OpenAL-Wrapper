using System.Runtime.InteropServices;

public enum AL
{
    AL_FALSE = 0x0000,
    AL_TRUE = 0x0001,
    AL_SOURCE_RELATIVE = 0x202,
    AL_CONE_INNER_ANGLE = 0x1001,
    AL_CONE_OUTER_ANGLE = 0x1002,
    AL_PITCH = 0x1003,
    AL_POSITION = 0x1004,
    AL_DIRECTION = 0x1005,
    AL_VELOCITY = 0x1006,
    AL_LOOPING = 0x1007,
    AL_BUFFER = 0x1009,
    AL_GAIN = 0x100A,
    AL_MIN_GAIN = 0x100D,
    AL_MAX_GAIN = 0x100E,
    AL_ORIENTATION = 0x100F,
    AL_CHANNEL_MASK = 0x3000,
    AL_SOURCE_STATE = 0x1010,
    AL_INITIAL = 0x1011,
    AL_PLAYING = 0x1012,
    AL_PAUSED = 0x1013,
    AL_STOPPED = 0x1014,
    AL_BUFFERS_QUEUED = 0x1015,
    AL_BUFFERS_PROCESSED = 0x1016,
    AL_SEC_OFFSET = 0x1024,
    AL_SAMPLE_OFFSET = 0x1025,
    AL_BYTE_OFFSET = 0x1026,
    AL_SOURCE_TYPE = 0x1027,
    AL_STATIC = 0x1028,
    AL_STREAMING = 0x1029,
    AL_UNDETERMINED = 0x1030,
    AL_FORMAT_MONO8 = 0x1100,
    AL_FORMAT_MONO16 = 0x1101,
    AL_FORMAT_STEREO8 = 0x1102,
    AL_FORMAT_STEREO16 = 0x1103,
    AL_REFERENCE_DISTANCE = 0x1020,
    AL_ROLLOFF_FACTOR = 0x1021,
    AL_CONE_OUTER_GAIN = 0x1022,
    AL_MAX_DISTANCE = 0x1023,
    AL_FREQUENCY = 0x2001,
    AL_BITS = 0x2002,
    AL_CHANNELS = 0x2003,
    AL_SIZE = 0x2004,
    AL_UNUSED = 0x2010,
    AL_PENDING = 0x2011,
    AL_PROCESSED = 0x2012,
    AL_NO_ERROR = 0x0000,
    AL_INVALID_NAME = 0xA001,
    AL_ILLEGAL_ENUM = 0xA002,
    AL_INVALID_ENUM = 0xA002,
    AL_INVALID_VALUE = 0xA003,
    AL_ILLEGAL_COMMAND = 0xA004,
    AL_INVALID_OPERATION = 0xA004,
    AL_OUT_OF_MEMORY = 0xA005,
    AL_VENDOR = 0xB001,
    AL_VERSION = 0xB002,
    AL_RENDERER = 0xB003,
    AL_EXTENSIONS = 0xB004,
    AL_DOPPLER_FACTOR = 0xC000,
    AL_DOPPLER_VELOCITY = 0xC001,
    AL_SPEED_OF_SOUND = 0xC003,
    AL_DISTANCE_MODEL = 0xD000,
    AL_INVERSE_DISTANCE = 0xD001,
    AL_INVERSE_DISTANCE_CLAMPED = 0xD002,
    AL_LINEAR_DISTANCE = 0xD003,
    AL_LINEAR_DISTANCE_CLAMPED = 0xD004,
    AL_EXPONENT_DISTANCE = 0xD005,
    AL_EXPONENT_DISTANCE_CLAMPED = 0xD006,
}

public enum ALC
{
    ALC_FALSE = 0x0000,
    ALC_TRUE = 0x0001,
    ALC_FREQUENCY = 0x1007,
    ALC_REFRESH = 0x1008,
    ALC_SYNC = 0x1009,
    ALC_MONO_SOURCES = 0x1010,
    ALC_STEREO_SOURCES = 0x1011,
    ALC_NO_ERROR = ALC_FALSE,
    ALC_INVALID_DEVICE = 0xA001,
    ALC_INVALID_CONTEXT = 0xA002,
    ALC_INVALID_ENUM = 0xA003,
    ALC_INVALID_VALUE = 0xA004,
    ALC_OUT_OF_MEMORY = 0xA005,
    ALC_DEFAULT_DEVICE_SPECIFIER = 0x1004,
    ALC_DEVICE_SPECIFIER = 0x1005,
    ALC_EXTENSIONS = 0x1006,
    ALC_MAJOR_VERSION = 0x1000,
    ALC_MINOR_VERSION = 0x1001,
    ALC_ATTRIBUTES_SIZE = 0x1002,
    ALC_ALL_ATTRIBUTES = 0x1003,
    ALC_DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012,
    ALC_ALL_DEVICES_SPECIFIER = 0x1013,
    ALC_CAPTURE_DEVICE_SPECIFIER = 0x310,
    ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x311,
    ALC_CAPTURE_SAMPLES = 0x312,
}

internal unsafe class OpenAL
{
    internal const string libraryPath = @$"OpenAL32.dll";

    // **************************** //
    // Error Functions              //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alGetError();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alcGetError(void* device);

    // **************************** //
    // Buffer Functions             //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGenBuffers(int n, uint* buffers);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alDeleteBuffers(int n, uint* buffers);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alIsBuffer(uint buffer);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alBufferData(uint buffer, int format, void* data, int size, int freq);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alBufferf(uint buffer, int param, float value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alBuffer3f(uint buffer, int param, float v1, float v2, float v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alBufferfv(uint buffer, int param, float* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alBufferi(uint buffer, int param, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alBuffer3i(uint buffer, int param, int v1, int v2, int v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alBufferiv(uint buffer, int param, int* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetBufferf(uint buffer, int pname, float* value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetBuffer3f(uint buffer, int pname, float* v1, float* v2, float* v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetBufferfv(uint buffer, int pname, float* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetBufferi(uint buffer, int pname, int* value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetBuffer3i(uint buffer, int pname, int* v1, int* v2, int* v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetBufferiv(uint buffer, int pname, int* values);

    // **************************** //
    // Source Functions             //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGenSources(int n, uint* sources);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alDeleteSources(int n, uint* sources);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alIsSource(uint source);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourcef(uint source, int param, float value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSource3f(uint source, int param, float v1, float v2, float v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourcefv(uint source, int param, float* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourcei(uint source, int param, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSource3i(uint source, int param, int v1, int v2, int v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourceiv(uint source, int param, int* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetSourcef(uint source, int param, float* value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetSource3f(uint source, int param, float* v1, float* v2, float* v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetSourcefv(uint source, int param, float* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetSourcei(uint source, int param, int* value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetSource3i(uint source, int param, int* v1, int* v2, int* v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetSourceiv(uint source, int param, int* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourcePlay(uint source);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourcePlayv(int n, uint* sources);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourcePause(uint source);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourcePausev(int n, uint* sources);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourceStop(uint source);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourceStopv(int n, uint* sources);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourceRewind(uint source);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourceRewindv(int n, uint* sources);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourceQueueBuffers(uint source, int n, uint* buffers);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSourceUnqueueBuffers(uint source, int n, uint* buffers);

    // **************************** //
    // Listener Functions           //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alListenerf(int param, float value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alListener3f(int param, float v1, float v2, float v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alListenerfv(int param, float* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alListeneri(int param, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alListener3i(int param, int v1, int v2, int v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alListeneriv(int param, int* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetListenerf(int param, float* value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetListener3f(int param, float* v1, float* v2, float* v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetListenerfv(int param, float* values);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetListeneri(int param, int* value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetListener3i(int param, int* v1, int* v2, int* v3);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetListeneriv(int param, int* values);

    // **************************** //
    // State Functions              //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alEnable(int capability);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alDisable(int capability);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alIsEnabled(int capability);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alGetBoolean(int param);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern double alGetDouble(int param);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern float alGetFloat(int param);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alGetInteger(int param);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetBooleanv(int param, int* data);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetDoublev(int param, double* data);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetFloatv(int param, float* data);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alGetIntegerv(int param, int* data);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern char* alGetString(int param);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alDistanceModel(int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alDopplerFactor(float value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alSpeedOfSound(float value);

    // **************************** //
    // Extension Functions          //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alIsExtensionPresent(char* extname);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void* alGetProcAddress(char* fname);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alGetEnumValue(char* ename);

    // **************************** //
    // Context Management Functions //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void* alcCreateContext(void* device, int* attrlist);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alcMakeContextCurrent(void* context);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alcProcessContext(void* context);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alcSuspendContext(void* context);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alcDestroyContext(void* context);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void* alcGetCurrentContext();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void* alcGetContextsDevice(void* context);

    // **************************** //
    // Context Device Functions     //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void* alcOpenDevice(char* devicename);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alcCloseDevice(void* device);

    // **************************** //
    // Context Extension Functions  //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alcIsExtensionPresent(void* device, char* extName);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void* alcGetProcAddress(void* device, char* funcName);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alcGetEnumValue(void* device, char* enumName);

    // **************************** //
    // Context State Functions      //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern char* alcGetString(void* device, int param);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alcGetIntegerv(void* device, int param, int size, int* data);

    // **************************** //
    // Context Capture Functions    //
    // **************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void* alcCaptureOpenDevice(char* devicename, int frequency, int format, int buffersize);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int alcCaptureCloseDevice(void* device);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alcCaptureStart(void* device);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alcCaptureStop(void* device);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void alcCaptureSamples(void* device, void* buffer, int samples);
}
